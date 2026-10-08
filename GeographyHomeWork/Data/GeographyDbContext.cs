using GeographyHomeWork.Models;
using Microsoft.EntityFrameworkCore;

namespace GeographyHomeWork.Data
{
    public class GeographyDbContext : DbContext
    {
        public GeographyDbContext(
            DbContextOptions<GeographyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Bulgaria",
                    Capital = "Sofia",
                    Population = 6400000
                },
                new Country
                {
                    Id = 2,
                    Name = "Germany",
                    Capital = "Berlin",
                    Population = 84000000
                },
                new Country
                {
                    Id = 3,
                    Name = "France",
                    Capital = "Paris",
                    Population = 68000000
                }
            );
        }
    }
}
