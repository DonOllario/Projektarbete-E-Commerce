using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class HandleProducts : Product
    {
        public string sSearch { get; set; }
        public string idSearch { get; set; }
        MenuHandler MyMenu = new MenuHandler();
        public List<Product> Products() // Skapar listan med alla produkter
        {
            List<Product> Products = new List<Product>();
            Products.Add(new Product { id = 1, name = "Business Shirt", price = 799, description = "A white business shirt made from cotton by Ralph Lauren", category = "Shirts" });
            Products.Add(new Product { id = 2, name = "Winter hat", price = 549, description = "A black winter hat made with yarn", category = "Hats" });
            Products.Add(new Product { id = 3, name = "Jeans", price = 799, description = "Blue ragged jeans made by JC", category = "Pants" });
            Products.Add(new Product { id = 4, name = "Cardigan", price = 4999, description = "Scarlet cardigan by Lacoste", category = "Sweaters" });
            Products.Add(new Product { id = 5, name = "Sunglasses", price = 1999, description = "Polarized lenses made by Ray-Ban", category = "Accessories" });
            Products.Add(new Product { id = 6, name = "Chinos", price = 499, description = "Purple chinos made by cheap monday", category = "Pants" });

            return Products;
        }

        

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

        /*public void FilterCategory(List<Product> Products)
        {
            
            Console.WriteLine("Choose category:");
            sSearch = Console.ReadLine();
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].category.Equals(sSearch))
                {
                    Console.WriteLine(Products[i].PrintName()); // Skriver ut namn på alla produkter i kategorin som passar sökordet
                    Console.WriteLine();
                }
            }
        }*/
        public void FilterCategory2(List<Product> Products) 
        {
            
            int input = Convert.ToInt32(Console.ReadLine());
            MyMenu.ClearConsoleKOTRM();
            switch (input)
            {
                case 1:
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
                    Console.WriteLine();
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
                    Console.WriteLine("You need to enter 1-5.");
                    break;
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

        

        public string GetidSearch()
        {
            return idSearch;
        }

        public string GetsSearch()
        {
            return sSearch;
        }
        

        public void AllCategories() // Skriver ut alla kategorier
        {
            Categories.AddRange(difcats);
            Console.WriteLine("Choose a category:");
            for (int i = 0; i < difcats.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + Categories[i]);

            }
        }
    }
}