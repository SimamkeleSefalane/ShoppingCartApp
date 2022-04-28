 using System.Collections.Generic; 
using System;

namespace ShoppingLibrary
{

    public class ShoppingCart
    {
        List<ShoppingCartItem1> _shoppingCartItems = new List<ShoppingCartItem1>();

        public void ListOfItems(ShoppingCartItem1 product)
        {
            _shoppingCartItems.Add(product);


        }

        public double GetSubTotal()
        {
            double subtotal = 0;
            foreach (ShoppingCartItem1 item in _shoppingCartItems)
            {
                subtotal = subtotal + item.ItemPrice;
            }
            return subtotal;
        }
        public double GetVatTotal()
        {
            double vattotal = 0;
            vattotal += 1.15 * GetSubTotal();
            return vattotal;
        }
        public List <ShoppingCartItem1> ShoppingCartItems()
        {
            return _shoppingCartItems;
        }

        
            

        
    }
}
