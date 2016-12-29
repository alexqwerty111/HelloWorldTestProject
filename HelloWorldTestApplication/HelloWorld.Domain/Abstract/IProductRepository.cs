using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Domain.Entities;

namespace HelloWorld.Domain.Abstract
{
    /// <summary>
    /// Интерфейс хранилища товаров
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Полный список товаров
        /// </summary>
        IEnumerable<Product> Products { get; }
    }
}
