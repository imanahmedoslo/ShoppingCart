

namespace ShoppingCartOppgave
{
    public class CartItem
    {
        public Item _addedItem;
        public int _amount;
        public CartItem(Item chosenProduct, int amount)
        {
            _amount = amount;
            _addedItem = chosenProduct;
        }
        public int CalculatePrice()
        {
            return _amount * _addedItem._price;
        }
        public void IncreaseAmount(int amount)
        {
            _amount += amount;
        }

        public void printCartItem()
        {
            Console.WriteLine($"Handlekurv: Produkt: {_addedItem._productName}, Antall:" +
                $" {_amount}, Pris pr stk: {_addedItem._price}, " +
                    $"totalpris for produkt: {CalculatePrice()}");
        }
    }
}

