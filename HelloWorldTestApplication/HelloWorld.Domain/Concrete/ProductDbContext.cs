using System.Data.Entity;
using HelloWorld.Domain.Entities;

namespace HelloWorld.Domain.Concrete
{
    /// <summary>
    /// Контекст БД
    /// </summary>
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<ProductOption> Options { get; set; }
    }
}
