using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    public class MenuHandler
    {
        List<string> menuOptions = new List<string>();
        List<string> signInOptions = new List<string>();
        bool displayMenuSaved = false;
        bool signInMenuSaved = false;

        public void DisplayMenu()
        {
            if (!displayMenuSaved)
            {
                menuOptions.Add("----- KOTRM Online Shop -----");
                menuOptions.Add("1. Browse our Catalogue.");
                menuOptions.Add("2. Show Shopping Cart.");
                menuOptions.Add("3. Sign up / Log in.");
                menuOptions.Add(" - Type Close to Exit.");
                displayMenuSaved = true;
            }

            menuOptions.ForEach(Console.WriteLine);
        }

        public void DisplaySignInMenu()
        {
            if (!signInMenuSaved)
            {
                signInOptions.Add("----- KOTRM Online Shop -----");
                signInOptions.Add("1. Sign In");
                signInOptions.Add("2. Log In");
                signInOptions.Add("3. Go Back");
                signInMenuSaved = true;
            }

            signInOptions.ForEach(Console.WriteLine);
        }

        public void ClearConsoleKOTRM()
        {
            Console.Clear();
            Console.WriteLine("----- KOTRM Online Shop -----");
        }

        public void GoBack()
        {
            Console.Clear();
            DisplayMenu();
        }
    }
}

