using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
     class Item
    {
        public string Product { get;  private set; }
        public int Price { get; private set; }
        //public int Amount { get; private set; } 

        public Item(string name, int price) { 
            Product = name;
            Price = price;
           
        }

       /* public int GetAmount( TheShoppingCart cart)
        {
            int Count = 0;
           foreach ( var item in cart.Items )
            {
                if (item==this)
                {
                    Count++;
                }
            } return Amount= Count;

        }*/

        
    }
}
