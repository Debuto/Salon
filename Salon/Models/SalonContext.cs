using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class SalonContext : DbContext
  {
    public DbSet<Client> Clients { get; set; }
    public DbSet<Stylist> Stylists { get; set; }

    public SalonContext(DbContextOptions options) : base(options) { }
  }
}