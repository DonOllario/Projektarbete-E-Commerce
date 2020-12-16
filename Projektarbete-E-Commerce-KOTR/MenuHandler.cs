using System;
using System.Collections.Generic;

namespace Projektarbete_E_Commerce_KOTR
{
    class MenuHandler
    {
        List<string> menuOptions = new List<string>();
        List<string> signInOptions = new List<string>();
        List<string> adminOptions = new List<string>();
        bool displayMenuSaved = false; //Adderar inte till listan nefter att det skett en gång
        bool signInMenuSaved = false; //Adderar inte till listan nefter att det skett en gång
        bool adminMenuSaved = false; //Adderar inte till listan nefter att det skett en gång

        public void DisplayMenu()
        {
            if (!displayMenuSaved)
            {
                menuOptions.Add("----- KOTRM Online Shop -----");
                menuOptions.Add("1. Browse our Catalogue.");
                menuOptions.Add("2. Show Shopping Cart.");
                menuOptions.Add("3. Sign Up / Log in.");
                menuOptions.Add("4. Admin");
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
                signInOptions.Add("1. Sign Up");
                signInOptions.Add("2. Log In");
                signInOptions.Add("3. Go Back");
                signInMenuSaved = true;
            }

            signInOptions.ForEach(Console.WriteLine);
        }

        public void DisplayAdminMenu() 
        {
            if (!adminMenuSaved)
            {
                adminOptions.Add("----- KOTRM Online Shop -----");
                adminOptions.Add("1. Add new product");
                adminOptions.Add("2. Remove existing product");
                adminOptions.Add("3. Change existing product");
                adminOptions.Add("4. Go Back");
                adminMenuSaved = true;
            }
            adminOptions.ForEach(Console.WriteLine);
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

