using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PremierAthletics.Models
{
  public class PremierAthleticsContextFactory : IDesignTimeDbContextFactory<PremierAthleticsContext>
  {

    PremierAthleticsContext IDesignTimeDbContextFactory<PremierAthleticsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PremierAthleticsContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new PremierAthleticsContext(builder.Options);
    }
  }
}