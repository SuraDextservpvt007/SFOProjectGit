using Microsoft.EntityFrameworkCore;
using SFO.Models.DBEntities;

namespace SFO.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Party> Party { get; set; }
        
    }
}
