using Microsoft.EntityFrameworkCore;
using WebAppMvc.Models.Entites;

namespace WebAppMvc.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
