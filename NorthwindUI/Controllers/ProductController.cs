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

        public IActionResult Index(int categoryId,int page=1)
        {
            int pageSize = 10;
            var products = _productService.GetProductsByCategoryId(categoryId).Data;
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page-1)*pageSize).Take(pageSize).ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddToCart()
        {

        }
    }
}
