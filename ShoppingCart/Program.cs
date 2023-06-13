// See https://aka.ms/new-console-template for more information
using ShoppingCartOppgave;

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









