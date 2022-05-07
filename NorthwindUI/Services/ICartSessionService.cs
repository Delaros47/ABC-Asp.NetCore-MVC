using Entities.Concrete;

namespace NorthwindUI.Services
{
    public interface ICartSessionService
    {

        Cart GetCart();
        void SetCart(Cart cart);

    }
}
