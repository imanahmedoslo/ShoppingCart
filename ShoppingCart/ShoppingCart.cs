namespace ShoppingCartOppgave
{
    class ShoppingCart
    {
        private List<CartItem> _products;
        public ShoppingCart()
        {
            _products = new List<CartItem>();
        }
        public void AddItemsToCart(Item item, int amount)
        {
            var existingProduct = _products.Find(product => product.ItemsAlign(item) == item);
            if (existingProduct == null)
            {
                var newestItem = new CartItem(item, amount);
                _products.Add(newestItem);
            }
            else
            {
                existingProduct.IncreaseAmount(amount);
            }
        }
        public void PrintProductList()
        {
            int totalPris = 0;
            if (_products.Count == 0)
            {
                Console.WriteLine("handlekurv er tom");
                return;
            }
            foreach (var product in _products)
            {
                product.printCartItem();
                totalPris += product.CalculatePriceByItem();
            }
            Console.WriteLine($"Totalpris: {totalPris}. Sum antall produkter {SumAllProducts()}");
        }
        public int SumAllProducts()
        {
            int totalCount = 0;
            foreach (var item in _products)
            {
                totalCount = item.AddAmount(totalCount);
            }
            return totalCount;
        }
    }
}
