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
            ProductLine test = new ProductLine(5);
            ProductLine test1 = new ProductLine(5);
            ProductLine test2 = new ProductLine(5);
            ProductLine test3 = new ProductLine(5);
            ProductLine test4 = new ProductLine(5);

            ProductLine[] productLines = { test, test1, test2, test3, test4 };

            Order testOrder = new Order(productLines, null);

            Console.WriteLine($"Totalpriset är: {testOrder.TotalPrice}:- och leveransadressen är: {testOrder.DeliveryAdress}.");
        }
    }
}
