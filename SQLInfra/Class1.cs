using Domain;
using Microsoft.EntityFrameworkCore;

namespace SQLInfra
{
    public class MetingDbContext : DbContext
    {
        public DbSet<Meting> Metingen { get; set; }

        public MetingDbContext(DbContextOptions<MetingDbContext> contextOptions) : 
            base(contextOptions)
        {
                
        }
  
    }
}