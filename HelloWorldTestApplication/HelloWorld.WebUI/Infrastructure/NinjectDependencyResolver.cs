using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using HelloWorld.Domain.Abstract;
using HelloWorld.Domain.Concrete;
using HelloWorld.Domain.Entities;
using Moq;
using Ninject;

namespace HelloWorld.WebUI.Infrastructure
{
    /// <summary>
    /// Распознователь зависимостей.
    /// </summary>
    /// <remarks>Предназначен для автоматической генерации экземрляров классов по типам интерфейсов</remarks>
    public class NinjectDependencyResolver : IDependencyResolver
    {
        /// <summary>
        /// Экземпляр нинжета
        /// </summary>
        private readonly IKernel _kernel;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="kernel">Экземпляр нинжета</param>
        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
            // Установить связки между интерфейсами и классами 
            AddBindings();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        /// <summary>
        /// Для создания связок между интерфейсам и классам
        /// </summary>
        private void AddBindings_Fake()
        {
            // Создать фиктивное отладочное хранилище товаров
            Mock<IProductRepository> mock = new Mock<IProductRepository>();

            ProductCategory gun = new ProductCategory { Name = "Оружие" };

            mock.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product {Name = "Холодильник", Category = gun, Description="Уронить с балкона на голову врагу", Price = 1499},
                new Product {Name = "Автомобиль", Category = gun, Description="Дождаться когда враг будет пересекать дорогу и переехать его",  Price = 2299},
                new Product {Name = "Зубочистка", Category = gun, Description="Воткнуть врагу в глаз",  Price = 899.4M}
            });

            // Регистрация фиктивного отладочного хранилища в качества реализатора интерфейса IProductRepository
            _kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }

        /// <summary>
        /// Для создания связок между интерфейсам и классам
        /// </summary>
        private void AddBindings()
        {
            // Регистрация фиктивного отладочного хранилища в качества реализатора интерфейса IProductRepository
            _kernel.Bind<IProductRepository>().To<ProductRepository>();
        }
    }
}