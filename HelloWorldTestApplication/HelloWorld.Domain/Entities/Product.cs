
using System.Collections.Generic;

namespace HelloWorld.Domain.Entities
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Product : NameBasic
    {
        /// <summary>
        /// Тип товара
        /// </summary>
        public ProductCategory Category { get; set; }

        /// <summary>
        /// Список возможностей товара
        /// </summary>
        public List<ProductOption> Options { get; set; }

        /// <summary>
        /// Описание 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
    }
}
