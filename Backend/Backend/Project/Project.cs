using System.ComponentModel.DataAnnotations;
using Backend.Teams;

namespace Backend.Project;

public class Project
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Manager { get; set; }
    [Required]
    public string Status { get; set; }
    [Required] 
    public Client.Client Client { get; set; }
    [Required]
    public ICollection<Team> Teams { get; set; }
}