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
            Console.WriteLine("Hello Kevin, Oliver, Tobias, Rikard. This is the start of our E-Commerce");
            ShoppingCart MyCart = new ShoppingCart();
            HandleProducts Clothes1 = new HandleProducts();
            Clothes1.CreateProducts();
            Clothes1.GetNames();
            Clothes1.SpecificProduct();
            MyCart.AddToCart();
        }
    }
}
