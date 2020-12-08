using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool menuWritten = false;
            String userInput;

            MenuHandler myMenu = new MenuHandler();
            InputManager Choice = new InputManager();

            while (true)
            {
                if (!menuWritten)
                {
                    myMenu.DisplayMenu();
                    menuWritten = true;
                }

                userInput = Console.ReadLine();
                Choice.HandleInput(userInput);
            }
        }
    }
}