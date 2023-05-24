using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class TheShoppingCart
    {
        public List<Item> Items { get; private set; }
        public int NumOfProducts { get;  private set; }
        public List <string> productNames { get; private set; }
        public TheShoppingCart() {
            Items=new List<Item>();
           NumOfProducts = Items.Count;
            productNames = new List<string>();
        }
        public void AddItemsToCart(Item item)
        {
           
            Items.Add(item);
            var AntallPrVare = GetAmountPerProduct(item);
            NumOfProducts = Items.Count;
            Console.WriteLine($"Du har {AntallPrVare} stk av {item.Product} i handlekurven din.");

        }
        public void PrintProductList()
        {

            int TotalPris = 0;
            if (Items.Count == 0)
            {
                Console.WriteLine("handlekurv er tom");
                return;

            } else
            {

            

               

            foreach (var item in Items)
                {
                    var AntallPrVare = GetAmountPerProduct(item);
                    int PrisPrVare = AntallPrVare * item.Price;


                    if (productNames.Contains(item.Product))
                    {
                        continue;
                    }
                    else { 
                    
                    Console.WriteLine($"Handlekurv: Produkt: {item.Product}, Antall: {AntallPrVare}, Pris pr stk: {item.Price}, " +
                            $"totalpris for produkt: {PrisPrVare}");
                    productNames.Add(item.Product);
                       
                    
                    //productNames.Add(item.Product);

                }
                    TotalPris += PrisPrVare;
                }

                Console.WriteLine($"Totalpris: {TotalPris}. Sum antall produkter{NumOfProducts}");
            }


        }
        public int GetAmountPerProduct(Item item)
        {
            int Count = 0;
            foreach (var product in Items)
            {
                if (product == item)
                {
                    Count++;
                }
            }
            return Count;
        }



    }
}
