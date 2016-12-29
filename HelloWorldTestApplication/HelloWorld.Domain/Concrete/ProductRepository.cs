using System.Collections.Generic;
using HelloWorld.Domain.Abstract;
using HelloWorld.Domain.Entities;

namespace HelloWorld.Domain.Concrete
{
    /// <summary>
    /// Репозиторий товаров
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        /// <summary>
        /// Контекст репозитория товаров
        /// </summary>
        readonly ProductDbContext _context = new ProductDbContext();

        /// <summary>
        /// Доступ к полному списку товаров
        /// </summary>
        public IEnumerable<Product> Products => _context.Products;
    }
}
