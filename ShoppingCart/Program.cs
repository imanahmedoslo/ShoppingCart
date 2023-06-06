// See https://aka.ms/new-console-template for more information
using ShoppingCartOppgave;




var A = new Item("A", 40);
var B = new Item("B", 70);
var C = new Item("C", 30);

ShoppingCart MyShoppingCart= new ShoppingCart();




MyShoppingCart.PrintProductList();
    MyShoppingCart.AddItemsToCart(A,1);
    MyShoppingCart.AddItemsToCart(B, 1);
    MyShoppingCart.AddItemsToCart(C, 2);
    MyShoppingCart.AddItemsToCart(A, 1);
    MyShoppingCart.PrintProductList();
   
   





 
 
