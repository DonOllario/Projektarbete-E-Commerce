using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    public class MenuHandler
    {
        List<string> menuOptions = new List<string>(); // En lista för alla mina alternativ.
        List<string> signInOptions = new List<string>();
        public void DisplayMenu()
        {
            menuOptions.Add("----- KOTR Online Shop -----");
            menuOptions.Add("1. Browse our Catalogue.");
            menuOptions.Add("2. Show Shopping Cart.");
            menuOptions.Add("3. Sign up / Log in.");
            menuOptions.Add(" - Type Close to Exit.");
            menuOptions.ForEach(Console.WriteLine);
        }

        public void DisplaySignInMenu()
        {
            signInOptions.Add("----- KOTR Online Shop -----");
            signInOptions.Add("1. Sign In");
            signInOptions.Add("2. Log In");
            signInOptions.Add("3. Go Back");
            signInOptions.ForEach(Console.WriteLine);
        }

    }
}

