﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Projektarbete_E_Commerce_KOTR
{
    class HandleProducts
    {
        
        public string idSearch;
        MenuHandler MyMenu = new MenuHandler();
        Product Products = new Product();

        public void GetClothes(List<Product> Products) // Skriver ut info om alla produkter
        {
            foreach (Product a in Products)
            {
                Console.WriteLine(a.PrintProducts());
                Console.WriteLine();
            }
        }

        public void GetNames(List<Product> Products) // Skriver ut namnet på alla produkter
        {
            foreach (Product name in Products)
            {
                Console.WriteLine(name.PrintName());
                Console.WriteLine();
            }
        }

        public void FilterCategory(string[] diffcats, List<Product> Products)
        {
            string input = "";
            while (true)
            {
                try
                {
                    Console.WriteLine("\n*************");
                    input = Console.ReadLine();
                    input = input.Substring(0, 1).ToUpper() + input.Substring(1);
                }
                catch (Exception)
                {

                    input = "";
                }

                if (diffcats.Contains(input))
                {
                    MyMenu.ClearConsoleKOTRM();
                    for (int i = 0; i < Products.Count; i++)
                    {
                        if (Products[i].category.Equals(input))
                        {
                            
                            Console.WriteLine();
                            Console.WriteLine(Products[i].PrintProducts()); // Skriver ut namn på alla produkter i kategorin som passar sökordet
                            Console.WriteLine();
                            
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Something went wrong, please try again");
                }
                
            }
        }

    public void SpecificProduct(List<Product> Products)
        {
            
            Console.WriteLine("Choose product");
            idSearch = Console.ReadLine();
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].name.Equals(idSearch))
                {

                    Console.WriteLine(Products[i].PrintProducts()); // Skriver ut all info om den produkt man valt
                    Console.WriteLine();
                }
            }
        }
        public void AllCategories(string[] diffcats) // Skriver ut alla kategorier
        {
            Console.WriteLine("Type in one of the categories: \n");
            for (int i = 0; i < diffcats.Length; i++)
            {
                Console.WriteLine(diffcats[i]);
            }
        }
    }
}