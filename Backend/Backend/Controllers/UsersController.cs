using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("api/users")]

public class UsersController : ControllerBase
{
    [HttpPost]
    public async Task<User> Post(UserRequest entity)
    {
        var user = new User
        {
            Id = Guid.NewGuid().ToString(),
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow,
            Username = entity.Username,
            Email = entity.Email
        };
}