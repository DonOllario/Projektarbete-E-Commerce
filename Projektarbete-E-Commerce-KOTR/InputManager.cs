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
            SignUpSystem signIn = new SignUpSystem();

            if (userInput == "1")
            {
                // Show Catalogue
                Console.WriteLine("Clothes");
            }
            else if (userInput == "2")
            {
                // Show Shopping Cart
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
                        signIn.HandleSignIn(signInInput);
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
