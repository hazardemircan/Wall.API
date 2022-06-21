using Microsoft.EntityFrameworkCore;

namespace Wall.API.Models
{
    public class WallDBContext : DbContext
    {
        public WallDBContext(DbContextOptions<WallDBContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer(@"Server=34.65.111.208;Database=walldb;Uid=hazardemircan;Password=walldb0296");
        }
    }
}
