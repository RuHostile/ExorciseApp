using Microsoft.EntityFrameworkCore;
namespace TestApp.Data
{
    public class ExorciseContext : DbContext
    {
        public DbSet<Exorcise> Exorcises { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Group> Groups { get; set; }

        public ExorciseContext(DbContextOptions options) : base(options)
        {

        }
    }
}
