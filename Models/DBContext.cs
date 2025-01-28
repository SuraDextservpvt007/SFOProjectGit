using Microsoft.EntityFrameworkCore;

namespace SFO.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Party> Parties { get; set; }
    }
}
