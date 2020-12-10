using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class ProductLine
    {
        double PricePerUnit;
        int quantity { get; set; }

        Product MyProducts = new Product();
        HandleProducts HandleLine = new HandleProducts();

        public void AddProductLine(List<Product> Products) 
        {
            
            //körs när man väljer produkt från Kevins lista
            Console.WriteLine("Type in the wanted product ID");
            int prodID = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < Products.Count; i++)
            {
                if (Products[i].id.Equals(prodID))
                {
                    Console.WriteLine("Type in the wanted quantity of the item.");
                    quantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine(Products[i].PrintProducts()); // Skriver ut den valda produkten
                    Console.WriteLine();
                }
            }
        }

        public void RemoveProduct()
        {

        }
    }
}
