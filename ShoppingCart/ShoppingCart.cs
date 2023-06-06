


namespace ShoppingCartOppgave
{
    class ShoppingCart
    {

        public readonly List<CartItem> Products;

        public ShoppingCart() {
          
            Products = new List<CartItem>();
            
        }
        public void AddItemsToCart(Item item, int amount)
        {
            var newestItem = new CartItem(item, amount);
            if (Products.Count == 0) {
             
                    Products.Add(newestItem); 
            }
            else if (Products.Count >0) {
                foreach (var product in Products)
                {
                    if (product.AddedItem == item)
                    {
                        product.IncreaseAmount(amount);
                        Console.WriteLine($"Du har {product.Amount} " +
                            $"stk av {product.AddedItem.ProductName} i handlekurven din.");
                        return;
                    }   
                }
                Products.Add(newestItem);
                Console.WriteLine($"Du har {newestItem.Amount} stk av " +
                    $"{newestItem.AddedItem.ProductName} i handlekurven din.");
            }
        }
        public void PrintProductList()
        {   int totalPris = 0;
            if (Products.Count == 0)
            {
                Console.WriteLine("handlekurv er tom");
                return;
            } 
            foreach (var product in Products)
                {
                    product.printCartItem();
                    totalPris += product.CalculatePrice(); 
                }
                Console.WriteLine($"Totalpris: {totalPris}. Sum antall produkter {SumAllProducts()}");
            }
        public int SumAllProducts()
        {  
            int totalCount = 0;
            foreach( var item in Products)
            { 
                totalCount+= item.Amount; 
            }
            return totalCount;
        }

    }
      

    

   
}
