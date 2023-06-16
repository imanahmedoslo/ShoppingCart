namespace ShoppingCartOppgave
{
    public class CartItem
    {
        private Item _addedItem;
        private int _amount;
        public CartItem(Item chosenProduct, int amount)
        {
            _amount = amount;
            _addedItem = chosenProduct;
        }
        public int CalculatePriceByItem()
        {
            return _addedItem.CalculatePrice(_amount);
        }
        public void IncreaseAmount(int amount)
        {
            _amount += amount;
        }

        public void printCartItem()
        {
            _addedItem.printProduct();
            Console.WriteLine(
                $" Antall: {_amount}," + $"totalpris for produkt: {CalculatePriceByItem()}");
        }
        public Item? ItemsAlign(Item item)
        {
            if (_addedItem == item)
            {
                return _addedItem;
            }
            else return null;
        }
        public int AddAmount(int totalSoFar)
        {
            return _amount + totalSoFar;
        }
    }
}

