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
                HandleClothes.FilterCategory(Clothes.diffCats, Clothes.Products());
                Console.WriteLine("****************************************************");
                Console.WriteLine("\n-Type >Add< to add product to cart");
                Console.WriteLine("\n-Type >Back< to return to menu");
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
                        Console.WriteLine("Incorrect Input, Please type 'Add' or 'Back' to continue");

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
                    String signUpInput = Console.ReadLine();

                    if (signUpInput == "1" || signUpInput == "2" || signUpInput == "3")
                    {
                        signUp.HandleSignUp(signUpInput);
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
