﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class HandleProducts : Products
    {
        string sSearch;
        string idSearch;
        Products MyClothes = new Products();
        public void CreateProducts() // Skapar listan med alla produkter
        {
            List<Products> CreateProducts = MyClothes.GetList();
            CreateProducts.Add(new Products { id = 1001, name = "Business Shirt", price = "799:-", description = "A white business shirt made from cotton by Ralph Lauren", category = "Shirts" });
            CreateProducts.Add(new Products { id = 2001, name = "Winter hat", price = "549:-", description = "A black winter hat made with yarn", category = "Hats" });
            CreateProducts.Add(new Products { id = 3001, name = "Jeans", price = "799:-", description = "Blue ragged jeans made by JC", category = "Pants" });
            CreateProducts.Add(new Products { id = 4001, name = "Cardigan", price = "4999:-", description = "Scarlet cardigan by Lacoste", category = "Sweaters" });
            CreateProducts.Add(new Products { id = 5001, name = "Sunglasses", price = "1999:-", description = "Polarized lenses made by Ray-Ban", category = "Accessories" });
        }

        public void GetClothes() // Skriver ut info om alla produkter
        {
            List<Products> GetClothes = MyClothes.GetList();
            foreach (Products a in GetClothes)
            {
                Console.WriteLine(a.PrintProducts());
                Console.WriteLine();
            }
        }
        public void GetCategories() // Skriver ut alla kategorier från listan
        {
            List<Products> GetCategories = MyClothes.GetList();
            foreach (Products s in GetCategories)
            {
                Console.WriteLine(s.PrintCategory());
                Console.WriteLine();
            }

        }
        public void GetNames() // Skriver ut namnet på alla produkter
        {
            List<Products> GetNames = MyClothes.GetList();
            foreach (Products name in GetNames)
            {
                Console.WriteLine(name.PrintName());
                Console.WriteLine();
            }
        }

        public void FilterCategory()
        {
            List<Products> filtercategory = MyClothes.GetList();
            Console.WriteLine("Choose category:");
            sSearch = Console.ReadLine();
            for (int i = 0; i < filtercategory.Count; i++)
            {
                if (filtercategory[i].category.Equals(sSearch))
                {
                    Console.WriteLine(filtercategory[i].PrintName()); // Skriver ut namn på alla produkter i kategorin som passar sökordet
                    Console.WriteLine();
                }
            }
        }

        public void SpecificProduct()
        {
            List<Products> SpecficProduct = MyClothes.GetList();
            Console.WriteLine("Choose product");
            idSearch = Console.ReadLine();
            for (int i = 0; i < SpecficProduct.Count; i++)
            {
                if (SpecficProduct[i].name.Equals(idSearch))
                {
                    Console.WriteLine(SpecficProduct[i].PrintProducts()); // Skriver ut all info om den produkt man valt
                    Console.WriteLine();
                }
            }
        }
    }
}
