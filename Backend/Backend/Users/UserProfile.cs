using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Users;

public class UserProfile : Entity
{
    [Required]
    public User User { get; set; }
    [Required]
    public string Teams { get; set; }
    [Required]
    public string FacebookLink { get; set; }
    [Required]
    [Phone]
    public string Phone { get; set; }
    [Required]
    public DateOnly Birthday { get; set; }
    [Required]
    public string Picture { get; set; }
}