using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class HandleProducts : Products
    {
        public string sSearch { get; set; }
        public string idSearch { get; set; }
        Products MyClothes = new Products();
        public void CreateProducts() // Skapar listan med alla produkter
        {
            List<Products> CreateProducts = MyClothes.GetList();
            //Products Shirt1 = new Products { id = 1001, name = "Business Shirt", price = "799:-", description = "A white business shirt made from cotton by Ralph Lauren", category = "Shirts" };
            //CreateProducts.Add(Shirt1);
            //Products Hat1 = new Products { id = 2001, name = "Winter hat", price = "549:-", description = "A black winter hat made with yarn", category = "Hats" };
            //CreateProducts.Add(Hat1);
            CreateProducts.Add(new Products { id = "3001", name = "Jeans", price = "799:-", description = "Blue ragged jeans made by JC", category = "2" });
            CreateProducts.Add(new Products { id = "4001", name = "Cardigan", price = "4999:-", description = "Scarlet cardigan by Lacoste", category = "3" });
            CreateProducts.Add(new Products { id = "5001", name = "Sunglasses", price = "1999:-", description = "Polarized lenses made by Ray-Ban", category = "4" });
            CreateProducts.Add(new Products { id = "6001", name = "Chinos", price = "499:-", description = "Purple chinos made by cheap monday", category = "2" });
        }

        // Category:
        //Shirts = 1
        //Pants = 2
        //Sweaters = 3
        //Accessories = 4


        public void GetClothes() // Skriver ut info om alla produkter
        {
            List<Products> GetClothes = MyClothes.GetList();
            foreach (Products a in GetClothes)
            {
                Console.WriteLine(a.PrintProducts());
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
                }
            }
        }

        public void SpecificProduct()
        {
            List<Products> SpecficProduct = MyClothes.GetList();
            Console.WriteLine("Choose product:");
            idSearch = Console.ReadLine();
            for (int i = 0; i < SpecficProduct.Count; i++)
            {
                if (SpecficProduct[i].name.Equals(idSearch))
                {

                    Console.WriteLine(SpecficProduct[i].PrintProducts()); // Skriver ut all info om den produkt man valt
                }
            }

            Console.WriteLine("1. Add to Cart");
            Console.WriteLine("2. Go Back");
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
            Console.WriteLine("Categories: ");
            Console.WriteLine();
            for (int i = 0; i < difcats.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + Categories[i]);

            }
        }
    }
}