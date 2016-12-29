using System.Collections.Generic;
using System.Data.Entity;
using HelloWorld.Domain.Entities;

namespace HelloWorld.Domain.Concrete
{
    /// <summary>
    /// Заполнение таблицы тестовыми данными
    /// </summary>
    /// <remarks>Инициализатор регистрируется в Global.asax.cs (метод Application_Start)</remarks>
    public class ProductDbInitializer : DropCreateDatabaseIfModelChanges<ProductDbContext>
    {
        /// <summary>
        /// Вызывается при необходимости заполнить БД новыми данными
        /// </summary>
        /// <param name="context">Контекст БД</param>
        protected override void Seed(ProductDbContext context)
        {
            ProductCategory gun = new ProductCategory { Name = "Оружие" };
            List<ProductCategory> categories = new List<ProductCategory>
            {
                gun
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            List<Product> products = new List<Product>
            {
                new Product {Name = "Холодильник", Category = gun, Description="Уронить с балкона на голову врагу", Price = 1499},
                new Product {Name = "Автомобиль", Category = gun, Description="Дождаться когда враг будет пересекать дорогу и переехать его",  Price = 2299},
                new Product {Name = "Зубочистка", Category = gun, Description="Воткнуть врагу в глаз",  Price = 899.4M}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
