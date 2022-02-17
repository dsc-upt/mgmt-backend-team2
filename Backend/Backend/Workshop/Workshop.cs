using System.ComponentModel.DataAnnotations;
using Backend.Users;

namespace Backend.Workshop;

public class Workshop : Entity
{
    [Required]
    public User Trainer { get; set; }
    [Required]
    public string Topic { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string CoverImage { get; set; }
    [Required]
    public  DateOnly DateStart { get; set; }
    [Required]
    public DateOnly DateEnd { get; set; }
    [Required]
    public int Seats { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public User[]  Participants { get; set; }
    [Required]
    public string Powerpoint { get; set; }
}