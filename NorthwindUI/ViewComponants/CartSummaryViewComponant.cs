using Microsoft.AspNetCore.Mvc;
using NorthwindUI.Models;
using NorthwindUI.Services;

namespace NorthwindUI.ViewComponants
{
    public class CartSummaryViewComponant:ViewComponent
    {

        private ICartSessionService _cartSessionService;
        public CartSummaryViewComponant(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public IViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }
    }
}
