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
            Console.WriteLine("Hello Kevin, Oliver, Tobias, Rikard. This is the start of our E-Commerce");

            bool menuWritten = false;
            MenuHandler myMenu = new MenuHandler();

            Console.WriteLine("----- KOTR Online Shop -----");

            while (true)
            {
                if (!menuWritten)
                {
                    myMenu.DisplayMenu();
                    menuWritten = true;
                    Console.WriteLine("Hej");
                }
            }
        }
    }
}