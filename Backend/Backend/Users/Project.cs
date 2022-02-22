using System.ComponentModel.DataAnnotations;

namespace Backend.Users;

public class Project
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Manager { get; set; }
    [Required]
    public string Status { get; set; }
    // client, teams??
}