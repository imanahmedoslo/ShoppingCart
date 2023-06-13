// See https://aka.ms/new-console-template for more information
using ShoppingCartOppgave;

/*
Lokale variabler skal ha liten forbokstav. F.eks. har du ikke dette på A, B og C i Program
unngå properties. Bruk private objektvariabler så langt det går - og kun properties når du må. F.eks. 
Products i ShoppingCart er nå public, men den skal være private (og da skal den hete _products)
ShoppingCart.AddItemsToCart: Ta bort løkken her. Du trenger ikke printe ut dette - det gjør ikke programmet du tok utgangspunkt i.
Det holder å vise frem ting når man kaller PrintProductlist
ShoppingCart.AddItemsToCart: flytt var newestItem = new CartItem(item, amount) inn i første del av if - altså bare hvis det skal lages et nytt produkt
ShoppingCart.AddItemsToCart: Hvis produktet finnes i handlekurven fra før, skal du bare oppdatere CartItem sin Amount
 bool productExcistsInCart= _products.All(element => element._addedItem == item);
            {

            }
 */


var a = new Item("A", 40);
var b = new Item("B", 70);
var c = new Item("C", 30);
ShoppingCart MyShoppingCart = new ShoppingCart();
MyShoppingCart.PrintProductList();
MyShoppingCart.AddItemsToCart(a, 1);
MyShoppingCart.AddItemsToCart(b, 1);
MyShoppingCart.AddItemsToCart(c, 2);
MyShoppingCart.AddItemsToCart(a, 1);
MyShoppingCart.PrintProductList();









