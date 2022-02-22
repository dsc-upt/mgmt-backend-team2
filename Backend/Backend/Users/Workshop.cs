using System.ComponentModel.DataAnnotations;

namespace Backend.Users;

public class Workshop : Entity
{
    [Required]
    public User Trainer { get; set; }
    [Required]
    public string Topic { get; set; }
    [Required]
    public string Description { get; set; }
    //cover image
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
    //ppt
}