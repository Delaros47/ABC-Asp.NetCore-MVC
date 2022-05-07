using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ICartService
    {

        IDataResult<List<CartItem>> GetAll(Cart cart);
        IResult AddToCart(Cart cart,Product product);
        IResult RemoveFromCart(Cart cart,int productId);

    }
}
