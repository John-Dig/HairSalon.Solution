using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<St> Sts { get; set; }
    public DbSet<Cl> Cls { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}
