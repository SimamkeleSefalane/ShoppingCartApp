using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem1
    {
        protected string _itemName;
        public double _eachItemPrice;

        public ShoppingCartItem1(string itemName, double eachItemPrice)
        {
            _itemName = itemName;
            _eachItemPrice = eachItemPrice;

        }
        public string ItemName
            { get { return _itemName; } }   

        public double ItemPrice
        { 
            get { return _eachItemPrice; } 
        }
        
    }
}
