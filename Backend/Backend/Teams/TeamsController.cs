using Backend.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Users;
[ApiController]
[Route("api/[controller]")]
public class TeamsController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public TeamsController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    [HttpGet]
    public List<Team> Get()
    {
        return new List<Team>();
    }

    [HttpPost]
    public async Task<GetTeamView> Add(AddTeamView teamView)
    {
        var teamLead = await AppDbContext.Users.FirstOrDefaultAsync(user => user.Id == teamView.TeamLeadId);
        if (teamLead is null)
        {
            throw new ArgumentException("Team lead not found");
        }
        
        var team = new Team
        {
            Id=Guid.NewGuid().ToString(),
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow,
            GitHubLink = teamView.GitHubLink,
            Name = teamView.Name,
            TeamLead = teamLead
        };
        await _appDbContext.Teams.AddAsync(team);
        await _appDbContext.SaveChangesAsync();
        return new GetTeamView
        {
            GithubLink = team.GitHubLink,
            Id=team.Id,
            Name=team.Name,
            TeamLead = new GetTeamLeadView 
            {
                Email=team.TeamLead.Email,
                Username=team.TeamLead.Username
            }
        };
    }
    
}