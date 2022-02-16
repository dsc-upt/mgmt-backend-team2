using System.ComponentModel.DataAnnotations;

namespace Backend.Users;

public class User : Entity
{
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    [Required] [EmailAddress] public string Email { get; set; }
    [Required] public string Roles { get; set; }
    [Required] public string Username { get; set; }
}

