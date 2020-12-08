using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleProducts Clothes1 = new HandleProducts();
            Clothes1.CreateProducts(); // Skickar över listan från HandleProducts till main
            while (true)
            {
                Clothes1.AllCategories();
                Clothes1.FilterCategory();
                Clothes1.SpecificProduct();
            }
        }
    }
}
