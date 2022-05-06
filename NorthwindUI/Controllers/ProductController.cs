using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using NorthwindUI.Models;

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
            var products= _productService.GetAll().Data;
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
            };

            return View(model);
        }
    }
}
