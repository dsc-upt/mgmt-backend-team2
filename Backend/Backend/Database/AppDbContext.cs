namespace Backend.Database;
using Backend.Users;
using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Team> Teams { get; set; }
    public static DbSet<User> Users { get; set; }
}