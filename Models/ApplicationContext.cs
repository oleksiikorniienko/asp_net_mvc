using System.Data.Entity;

namespace aspnet2.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
