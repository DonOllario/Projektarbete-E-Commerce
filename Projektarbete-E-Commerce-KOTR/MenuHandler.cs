using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    public class MenuHandler
    {
        public MenuHandler()
        {

        }

        List<string> menuOptions = new List<string>(); // En lista för alla mina alternativ.

        public void DisplayMenu()
        {
            menuOptions.Add("Alternativ 1.");
            menuOptions.Add("Alternativ 2.");
            menuOptions.Add("Skriv Close for att avsluta.");
            menuOptions.ForEach(Console.WriteLine);
        }

    }
}

