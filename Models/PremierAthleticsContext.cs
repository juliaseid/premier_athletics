using Microsoft.EntityFrameworkCore;

namespace PremierAthletics.Models
{
  public class PremierAthleticsContext : DbContext
  {
    public virtual DbSet<Athlete> Athletes { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<AthleteTeam> AthleteTeam { get; set; }
    public DbSet<DocumentTeam> DocumentTeam { get; set; }
    public DbSet<HSeSignature> eSignatures {get; set;}

    public PremierAthleticsContext(DbContextOptions options) : base(options) { }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //   optionsBuilder.UseLazyLoadingProxies();
    // }
  }
}