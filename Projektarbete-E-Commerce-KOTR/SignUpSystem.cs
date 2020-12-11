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

            if (SignInInput == "1")
            {
                //Sign Up
                Console.WriteLine("Sign Up");
            }
            else if (SignInInput == "2")
            {
                //Log in
                Console.WriteLine("Log in");
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
