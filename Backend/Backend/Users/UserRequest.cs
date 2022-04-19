using System.ComponentModel.DataAnnotations;

namespace Backend.Users;

public class UserRequest : Entity
{
    [Required] public string FirstName { get; set; }
    
    public DateTime Created { get; set; }
    [Required] public string LastName { get; set; }
    [Required] [EmailAddress] public string Email { get; set; }
    [Required] public string Roles { get; set; }
    
}