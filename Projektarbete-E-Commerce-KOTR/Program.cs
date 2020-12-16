using System;

namespace Projektarbete_E_Commerce_KOTR
{
    class Program
    {
        static void Main()
        {
            bool menuWritten = false;
            String userInput;

            MenuHandler myMenu = new MenuHandler();
            InputManager Choice = new InputManager();

            Product ProductReference = new Product();


            while (true)
            {
                if (!menuWritten)
                {

                    ProductReference.Products();
                    myMenu.DisplayMenu();
                    menuWritten = true;
                }

                userInput = Console.ReadLine();
                Choice.HandleInput(userInput);
            }
        }
    }
}