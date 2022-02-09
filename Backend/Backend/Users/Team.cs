using System.ComponentModel.DataAnnotations;

namespace Backend.Users;

public class Team : Entity
{
    
    [Required]
    private User TeamLead { get; set; } //asa?
    
    [Required]
    public string Name { get; set; }
    [Required]
    public string GitHubLink { get; set; }
    

}