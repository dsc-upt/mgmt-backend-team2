using System.ComponentModel.DataAnnotations;
using Backend.Users;

namespace Backend.Teams;

public class Team : Entity
{
    [Required] public User TeamLead { get; set; }

    [Required] public string Name { get; set; }

    [Required] public string GitHubLink { get; set; }
}