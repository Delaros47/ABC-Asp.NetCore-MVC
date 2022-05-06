using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NorthwindUI.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
