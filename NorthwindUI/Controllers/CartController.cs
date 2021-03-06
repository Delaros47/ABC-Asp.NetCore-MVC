using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using NorthwindUI.Services;

namespace NorthwindUI.Controllers
{
    public class CartController : Controller
    {

        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }



        public IActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.Get(productId).Data;
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message",String.Format("Your product,{0} was successfully added to the cart",productToBeAdded.ProductName));
            return RedirectToAction("Index","Product");
        }
    }
}
