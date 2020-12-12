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

        public void FilterCategory(List<Product> Products) 
        {
            
            int input = 0;
            int[] CategoryChoices = { 1, 2, 3, 4, 5 };
            while(!CategoryChoices.Contains(input)) 
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    input = 6;
                }
                
                switch (input)
                {
                    case 1:
                        MyMenu.ClearConsoleKOTRM();
                        Console.WriteLine("Shirts: ");
                        string CatVar1 = "Shirts";
                        for (int i = 0; i < Products.Count; i++)
                        {
                            if (Products[i].category.Equals(CatVar1))
                            {
                                Console.WriteLine(Products[i].PrintProducts()); // Skriver ut namn på alla produkter i kategorin som passar sökordet
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        MyMenu.ClearConsoleKOTRM();
                        Console.WriteLine("Pants: ");
                        string CatVar2 = "Pants";
                        for (int i = 0; i < Products.Count; i++)
                        {
                            if (Products[i].category.Equals(CatVar2))
                            {
                                Console.WriteLine(Products[i].PrintProducts()); // Skriver ut namn på alla produkter i kategorin som passar sökordet
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3:
                        MyMenu.ClearConsoleKOTRM();
                        Console.WriteLine("Glasses: ");
                        string CatVar3 = "Glasses";
                        for (int i = 0; i < Products.Count; i++)
                        {
                            if (Products[i].category.Equals(CatVar3))
                            {
                                Console.WriteLine(Products[i].PrintProducts()); // Skriver ut namn på alla produkter i kategorin som passar sökordet
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 4:
                        MyMenu.ClearConsoleKOTRM();
                        Console.WriteLine("Sweaters: ");
                        string CatVar4 = "Sweaters";
                        for (int i = 0; i < Products.Count; i++)
                        {
                            if (Products[i].category.Equals(CatVar4))
                            {
                                Console.WriteLine(Products[i].PrintProducts()); // Skriver ut namn på alla produkter i kategorin som passar sökordet
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 5:
                        MyMenu.ClearConsoleKOTRM();
                        Console.WriteLine("Hats: ");
                        string CatVar5 = "Hats";
                        for (int i = 0; i < Products.Count; i++)
                        {
                            if (Products[i].category.Equals(CatVar5))
                            {
                                Console.WriteLine(Products[i].PrintProducts()); // Skriver ut namn på alla produkter i kategorin som passar sökordet
                                Console.WriteLine();
                            }
                        }
                        break;
                    default:
                        input = 0;
                        Console.WriteLine("You need to enter 1-5.");
                        break;
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
            Console.WriteLine("Choose a category:");
            for (int i = 0; i < Products.diffCats.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + Products.Categories[i]);

            }
        }
    }
}