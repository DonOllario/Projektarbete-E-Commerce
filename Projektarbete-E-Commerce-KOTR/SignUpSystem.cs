using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    public class SignUpSystem
    {
        public void HandleSignUp(String SignInInput)
        {
            MenuHandler myMenu = new MenuHandler();

            if (SignInInput == "1")
            {
                //Sign Up
                myMenu.ClearConsoleKOTRM();
                Console.WriteLine("          -Sign Up-\n");
                Account.SignUp();
                Console.WriteLine("Enter 3 to go back"); // Om det går, kanske ändra så att man skriver in något annat än 3? Kan kännas lite konstigt
            }
            else if (SignInInput == "2")
            {
                //Log in
                myMenu.ClearConsoleKOTRM();
                Console.WriteLine("          -Log in-\n");
                Account.LogIn();
                Console.WriteLine("Enter 3 to go back"); // Om det går, kanske ändra så att man skriver in något annat än 3? Kan kännas lite konstigt
            }
            else if (SignInInput == "3") // Om det går, kanske ändra så att man skriver in något annat än 3? Kan kännas lite konstigt
            {
                //Go back
                myMenu.GoBack();
            }
            else
            {
                Console.WriteLine("Incorrect Input, Please try again");
            }
        }
    }
}
