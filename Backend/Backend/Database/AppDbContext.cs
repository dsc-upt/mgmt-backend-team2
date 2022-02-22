using Backend.Teams;
using Backend.Users;
using Microsoft.EntityFrameworkCore;

namespace Backend.Database;
//<Compile Include="Database\AppDbContext.cs" /> era pe linia 24 in Backend.csproj
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Team> Teams { get; set; }
    public DbSet<User> Users { get; set; }
}