using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cart
    {

        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        public List<CartItem> CartItems { get; set; }

        public decimal Total
        {
            get { return CartItems.Sum(c=>c.Product.UnitPrice*c.Quantity); }
        }

    }
}
