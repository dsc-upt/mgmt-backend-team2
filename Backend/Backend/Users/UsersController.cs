using Backend.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

namespace Backend.Users;

[ApiController]
[Route("api/users")]

public class UsersController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public UsersController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpPost]
    public async Task<User> Post(UserRequest entity)
    {
        var user = new User
        {
            Id = Guid.NewGuid().ToString(),
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            Roles = entity.Roles
        };
        return user;
    }

   // private var result = await.... (user);
   // return

}




   