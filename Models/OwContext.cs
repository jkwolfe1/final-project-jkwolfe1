using Microsoft.EntityFrameworkCore;

namespace Project.Models
{
    public class OwContext : DbContext
    {
        public OwContext (DbContextOptions<OwContext> options)
            :base(options)
            {   
            }
            public DbSet<Hero> Heroes {get; set;}
            public DbSet<Map> Maps {get; set;}
    }
}