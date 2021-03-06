using System.ComponentModel.DataAnnotations;

namespace Backend.Users;

public class Client : Entity
{
    [Required]
    public string Name { get; set; }
    //ContactPerson
    [Required]
    public User ContactPerson { get; set; }//e ok?
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [Phone]
    public string Phone { get; set; }
}