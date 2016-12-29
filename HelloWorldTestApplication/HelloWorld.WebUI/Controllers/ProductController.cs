using System.Web.Mvc;
using HelloWorld.Domain.Abstract;

namespace HelloWorld.WebUI.Controllers
{
    public class ProductController : Controller
    {
        /// <summary>
        /// Хранилище товаров
        /// </summary>
        private readonly IProductRepository _repository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="repository">Хранилище товаров</param>
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Визуализация представления, сожержащего полный сприсок товаров
        /// </summary>
        /// <returns>Визуализация полного списка товаров</returns>
        /// <remarks>Требуется регистрация пути в RegisterRoutes(RouteCollection routes)</remarks>
        public ViewResult List()
        {
            return View(_repository.Products);
        }
    }
}