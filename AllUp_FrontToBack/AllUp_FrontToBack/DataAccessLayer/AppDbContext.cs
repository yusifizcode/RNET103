using AllUp_FrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace AllUp_FrontToBack.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Feature> Features { get; set; }
    }
}
