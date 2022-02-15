using System.ComponentModel.DataAnnotations;
namespace Backend.Users;

public class Team : Entity
{
    [Required] public User TeamLead { get; set; }

    [Required] public string Name { get; set; }

    [Required] public string GitHubLink { get; set; }
}