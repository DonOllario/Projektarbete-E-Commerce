using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    public class InputManager
    {
        public void HandleInput(String userInput)
        {
            MenuHandler myMenu = new MenuHandler();
            SignUpSystem signUp = new SignUpSystem();
            HandleProducts Clothes = new HandleProducts();
            ProductLine item = new ProductLine();

            if (userInput == "1")
            {
                // Show Catalogue
                myMenu.ClearConsoleKOTRM();
                Clothes.AllCategories();
                Clothes.FilterCategory2(Clothes.Products());
                Console.WriteLine("-Add product to cart-");
                Console.WriteLine("Type >Add< to add product to cart");
                userInput = Console.ReadLine();
                userInput.ToLower();
                if (userInput == "add")
                {
                    item.AddProductLine(Clothes.Products());
                }
            }
            else if (userInput == "2")
            {
                // Show Shopping Cart
                // myCart.GetCart();
                Console.WriteLine("Cart");
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
