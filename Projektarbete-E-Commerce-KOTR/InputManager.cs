using System;
using System.Linq;

namespace Projektarbete_E_Commerce_KOTR
{
    class InputManager
    {
        MenuHandler myMenu = new MenuHandler();
        SignUpSystem signUp = new SignUpSystem();
        HandleProducts HandleClothes = new HandleProducts();
        ShoppingCart myCart = new ShoppingCart();
        AdminSystem myAdminHandler = new AdminSystem();

        //enum InputEnum 
        //{
        //    ViewProducts=1,
        //    ShowShoppingCart,
        //    SignUpOrLogIn,
        //    Admin
        //}

        public void HandleInput(String userInput)
        {
            
            if (userInput == "1")
            {
                // Show Catalogue
                myMenu.ClearConsoleKOTRM(); //Clear
                HandleClothes.AllCategories(Product.diffCats); // Visar alla Kategorier
                HandleClothes.FilterCategory(Product.diffCats, Product.ProductList); // Filtrerar vilka produkter som ska visas
                Console.WriteLine("****************************************************");
                Console.WriteLine("\n-Type >Add< to add product to cart");
                Console.WriteLine("\n-Type >Back< to return to menu");
                while (true)
                {
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                    if (userInput == "add")
                    {
                        myCart.AddProductLine(); //Lägger till en produkt genom ProductLine till ShoppingCart
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
                // Sign up / log in
                Console.Clear();
                myMenu.DisplaySignInMenu();

                while (true)
                {
                    String signUpInput = Console.ReadLine();

                    if (signUpInput == "1" || signUpInput == "2" || signUpInput == "3" )
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
            else if (userInput == "4")
            {
                // Admin Menu
                Console.Clear();
                if (Account.LoginStatus)
                {
                    myMenu.DisplayAdminMenu();

                    while (true)
                    {
                        string AdminInput = Console.ReadLine();

                        if (AdminInput == "1" || AdminInput == "2" || AdminInput == "3" || AdminInput == "4")
                        {
                            myAdminHandler.HandleAdmin(AdminInput);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Input, Please try again");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You need to login to access");
                    Console.WriteLine("Press any key to go back");
                    Console.ReadKey();
                    myMenu.GoBack();
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
