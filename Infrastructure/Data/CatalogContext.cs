using ApplicationCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=CatalogVGames;Trusted_Connection=True;");
        }
    }
}