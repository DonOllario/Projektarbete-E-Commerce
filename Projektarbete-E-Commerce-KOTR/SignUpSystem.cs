using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    public class SignUpSystem
    {
        MenuHandler myMenu = new MenuHandler();
        public void HandleSignIn(String SignInInput)
        {
            MenuHandler myMenu = new MenuHandler();
            konto konto = new konto();

            if (SignInInput == "1")
            {
                //Sign Up
                Console.WriteLine("Sign Up");
                konto.signup();
                Console.WriteLine("Enter 3 to go back");
            }
            else if (SignInInput == "2")
            {
                //Log in
                Console.WriteLine("Log in");
                konto.SignIn();
                Console.WriteLine("Enter 3 to go back");
            }
            else if (SignInInput == "3")
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
