using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart basket = new ShoppingCart();
            var productItem = new ShoppingCartItem1("xbox", 3950.99);
            basket.ListOfItems(productItem);

            productItem = new ShoppingCartItem1("ps4", 5999.49);
            basket.ListOfItems(productItem);

            List<ShoppingCartItem1> showProduct = basket.ShoppingCartItems();
            foreach(ShoppingCartItem1 item in showProduct)
            {
                Console.Write(item.ItemName + "\t\t");
                Console.WriteLine(item.ItemPrice);
            }
            Console.WriteLine("");
            Console.WriteLine("subtotal: \t" + basket.GetSubTotal());
            Console.WriteLine("withVat: \t" + basket.GetVatTotal());

        }
    }
}
