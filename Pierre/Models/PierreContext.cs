using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pierre.Models
{
  public class PierreContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Flavor> Flavors { get; set; }

    public DbSet<Treat> Treats { get; set; }

    public DbSet<FlavorTreat> FlavorTreats { get; set; }

    public PierreContext(DbContextOptions options) : base (options) { }
  }
}