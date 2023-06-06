

namespace ShoppingCartOppgave
{
     public class Item
    {
        public string ProductName { get;  private set; }
        public int Price { get; private set; }

        public Item(string name, int price) { 
            ProductName = name;
            Price = price;
           
        }

        
    }
}
