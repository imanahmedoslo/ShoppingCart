namespace ShoppingCartOppgave
{
    public class Item
    {
        private string _productName;
        private int _price;
        public Item(string name, int price)
        {
            _productName = name;
            _price = price;
        }

        public int CalculatePrice(int amount)
        {
            return _price * amount;
        }
        public void printProduct()
        {
            Console.WriteLine($"Handlekurv: Produkt: {_productName}, Pris pr stk: {_price}, ");
        }
    }
}
