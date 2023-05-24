// See https://aka.ms/new-console-template for more information
using ShoppingCart;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

var A = new Item("A", 40);
var B = new Item("B", 70);
var C = new Item("C", 30);
//var ChosenProduct = "";
var AllItems = new List<Item> { A, B, C };
var MyShoppingCart= new TheShoppingCart();
run();
void run()
{
    MyShoppingCart.PrintProductList();
   // Console.WriteLine($"this is it {MyShoppingCart.Items.Count}");
    MyShoppingCart.AddItemsToCart(A);
    MyShoppingCart.AddItemsToCart(B);
    MyShoppingCart.AddItemsToCart(C);
    MyShoppingCart.AddItemsToCart(A);
    MyShoppingCart.PrintProductList();
    // AllItems.Add(A);
    //Console.WriteLine($"here is a list off all our products, choose which one you want to add to cart: ");
    // foreach (var item in AllItems)
    // {

       /* Console.WriteLine($"{item.Product}. Price: {item.Price}");
         ChosenProduct= Console.ReadLine().ToUpper();
        if (ChosenProduct== item.Product)
        {
            MyShoppingCart.AddItemsToCart(item);
            Console.WriteLine($" You have the following in your shopping cart: { MyShoppingCart.getProductList()}");
        }
    //}*/
   

}



  // SimpleShoppingCartDemo.Run();
 
 
