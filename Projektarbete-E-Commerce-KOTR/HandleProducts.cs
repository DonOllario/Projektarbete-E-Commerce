using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    input = input.ToLower();
                }
                catch (Exception)
                {

                    input = "";
                }

                for (int i = 0; i < Products.Count; i++)
                {
                    Products[i].category = Products[i].category.ToLower();
                }
                for (int i = 0; i < diffcats.Length; i++)
                {
                    diffcats[i] = diffcats[i].ToLower();
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

                    string[] TempArray = new string[Products.Count];
                    for (int i = 0; i < Products.Count; i++)
                    {
                        TempArray[i] = Products[i].category;
                        TempArray[i] = TempArray[i].Substring(1, 1).ToUpper();
                        Products[i].category = TempArray[i];
                    }
                    for (int i = 0; i < diffcats.Length; i++)
                    {
                        diffcats[i] = diffcats[i].Substring(0, 0).ToUpper();
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
        public void AllCategories() // Skriver ut alla kategorier
        {
            Products.Categories.AddRange(Products.diffCats);
            Console.WriteLine("Type in one of the categories: \n");
            for (int i = 0; i < Products.diffCats.Length; i++)
            {
                Console.WriteLine(Products.Categories[i]);

            }
        }
    }
}