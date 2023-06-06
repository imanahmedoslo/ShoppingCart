

namespace ShoppingCartOppgave
{
    public class CartItem
    {
        public Item AddedItem;
       public int Amount { get; private set; }

        public CartItem(Item chosenProduct, int amount)
        {
            Amount = amount;
            AddedItem = chosenProduct;
        }
        public int CalculatePrice()
        {
            return Amount * AddedItem.Price;
        }

        public void IncreaseAmount(int amount)
        {
            Amount += amount;
        }

        public void printCartItem()
        {
                Console.WriteLine($"Handlekurv: Produkt: {AddedItem.ProductName}, Antall:" +
                    $" {Amount}, Pris pr stk: {AddedItem.Price}, " +
                        $"totalpris for produkt: {CalculatePrice()}");

               

            }
        }
    }

