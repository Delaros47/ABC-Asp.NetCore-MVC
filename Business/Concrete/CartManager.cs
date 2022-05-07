using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public IResult AddToCart(Cart cart, Product product)
        {
            CartItem cartItem = cart.CartItems.FirstOrDefault(c=>c.Product.ProductId==product.ProductId);
            if (cartItem != null)
            {
                cartItem.Quantity++;
                return new SuccessResult();
            }
            cart.CartItems.Add(new CartItem
            {
                Product=product,
                Quantity=1
            });
            return new SuccessResult();
        }

        public IDataResult<List<CartItem>> GetAll(Cart cart)
        {
            return new SuccessDataResult<List<CartItem>>(cart.CartItems);
        }

        public IResult RemoveFromCart(Cart cart, int productId)
        {
            cart.CartItems.Remove(cart.CartItems.FirstOrDefault(c=>c.Product.ProductId==productId));
            return new SuccessResult();
        }
    }
}
