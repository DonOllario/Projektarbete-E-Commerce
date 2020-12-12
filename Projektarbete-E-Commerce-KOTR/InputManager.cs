using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    public class InputManager
    {
        MenuHandler myMenu = new MenuHandler();
        SignUpSystem signUp = new SignUpSystem();
        Product Clothes = new Product();
        HandleProducts HandleClothes = new HandleProducts();
        ShoppingCart myCart = new ShoppingCart();

        public void HandleInput(String userInput)
        {

            if (userInput == "1")
            {
                // Show Catalogue
                myMenu.ClearConsoleKOTRM();
                HandleClothes.AllCategories();
                HandleClothes.FilterCategory2(Clothes.Products());
                Console.WriteLine("-Add product to cart-");
                Console.WriteLine("Type >Add< to add product to cart");
                Console.WriteLine("Type >Back< to return to menu");
                while (true)
                {
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                    if (userInput == "add")
                    {
                        myCart.AddProductLine();
                        break;
                    }
                    else if (userInput == "back")
                    {
                        myMenu.GoBack();
                        break;
                    }
                    else
                        Console.WriteLine("Incorrect Input, Please type 'Add' to continue");

                }
            }
            else if (userInput == "2")
            {
                // Show Shopping Cart
                //myMenu.ClearConsoleKOTRM();
                if ((myCart.CartList != null) && (!myCart.CartList.Any()))
                {
                    Console.WriteLine("the cart is currently empty.");
                }
                else
                {
                    myCart.PrintCart(myCart.CartList);
                }
            }
            else if (userInput == "3")
            {
                // Sign in / log in
                Console.Clear();
                myMenu.DisplaySignInMenu();

                while (true)
                {
                    String signInInput = Console.ReadLine();

                    if (signInInput == "1" || signInInput == "2" || signInInput == "3")
                    {
                        signUp.HandleSignIn(signInInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input, Please try again");
                    }
                }

            }
            else if (userInput == "Close" || userInput == "close")
            {
                Console.WriteLine("Exiting KOTR");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Incorrect Input, Please try again");
            }
        }
    }
}
