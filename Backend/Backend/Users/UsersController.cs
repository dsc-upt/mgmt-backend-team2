using Backend.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Users;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public UsersController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpGet]
    public List<User> Get()
    {
        return new List<User>();
    }

    // [HttpGet]
    // public async Task<User> GetId(UserRequest userRequest)
    // {
    //     var user = await _appDbContext.Users.FirstOrDefaultAsync(user => user.Id == userRequest.Id);
    //     if (user is null)
    //     {
    //         throw new ArgumentException("User not found");
    //     }
    //     return user;
    // }

    [HttpPost]
    public async Task<GetUserView> Add(AddUserView userView)
    {
        var user = new User
        {
            Id = Guid.NewGuid().ToString(),
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow,
            FirstName = userView.FirstName,
            LastName = userView.LastName,
            Email = userView.Email,
            Roles = userView.Roles
        };
        return new GetUserView
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Roles = user.Roles
        };
    }

    [HttpDelete]
    public async void Remove(User userRequest)
    {
        var user = await _appDbContext.Users.FirstOrDefaultAsync(user => user.Id == userRequest.Id);
        if (user is null)
        {
            throw new ArgumentException("User not found");
        }

        _appDbContext.Users.Remove(user);
        await _appDbContext.SaveChangesAsync();
    }

    [HttpPut]
    public async Task<User> Update(UserRequest userRequest)
    {
        var user = new User
        {
            Id = userRequest.Id,
            Created = userRequest.Created,
            Updated = DateTime.UtcNow,
            FirstName = userRequest.FirstName,
            LastName = userRequest.LastName,
            Email = userRequest.Email,
            Roles = userRequest.Roles
        };
        _appDbContext.Users.Update(user);
        await _appDbContext.SaveChangesAsync();
        return user;
    }
}