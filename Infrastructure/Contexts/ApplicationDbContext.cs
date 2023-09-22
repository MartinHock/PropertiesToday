using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :
        base(options)
        {
        }

        public DbSet<Domain.Property>? Properties { get; set; }
        public DbSet<Domain.Image>? Images { get; set; }

    }
}