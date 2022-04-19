using System.ComponentModel.DataAnnotations;

namespace Backend.Users;

public class GetUserView 
{
    public string FirstName { get; set; }
     public string LastName { get; set; }
     [EmailAddress] public string Email { get; set; }
     public string Roles { get; set; }
    
}