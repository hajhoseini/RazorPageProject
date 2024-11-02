using Microsoft.EntityFrameworkCore;

namespace RazorPageProject.Models.Data
{
    public class DataBaseContext : DbContext
    {       
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}