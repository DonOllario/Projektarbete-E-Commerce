using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    public class Program
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