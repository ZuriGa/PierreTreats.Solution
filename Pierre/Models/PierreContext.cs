using Microsoft.EntityFrameworkCore;

namespace Pierre.Models
{
  public class PierreContext : DbContext
  {
    public DbSet<Flavor> Flavors { get; set; }

    public PierreContext(DbContextOptions options) : base (options) { }
  }
}