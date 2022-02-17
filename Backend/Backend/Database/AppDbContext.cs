using Backend.Teams;
using Backend.Users;
using Microsoft.EntityFrameworkCore;

namespace Backend.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Team> Teams { get; set; }
    public DbSet<User> Users { get; set; }
}