using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class Product
    {
        public int id;
        public string name;
        public double price;
        public string description;
        public string category;
        public int quantity;
        public double LinePrice;
        public string[] diffCats = { "Shirts", "Pants", "Glasses", "Sweaters", "Hats" };
        public List<string> Categories = new List<string>();
        List<Product> ProductList = new List<Product>();

        public List<Product> Products() // Skapar listan med alla produkter
        {
            ProductList.Add(new Product { id = 1, name = "Business Shirt", price = 799, description = "A white business shirt made from cotton by Ralph Lauren", category = "Shirts" });
            ProductList.Add(new Product { id = 2, name = "Winter hat", price = 549, description = "A black winter hat made with yarn", category = "Hats" });
            ProductList.Add(new Product { id = 3, name = "Jeans", price = 799, description = "Blue ragged jeans made by JC", category = "Pants" });
            ProductList.Add(new Product { id = 4, name = "Cardigan", price = 4999, description = "Scarlet cardigan by Lacoste", category = "Sweaters" });
            ProductList.Add(new Product { id = 5, name = "Sunglasses", price = 1999, description = "Polarized lenses made by Ray-Ban", category = "Glasses" });
            ProductList.Add(new Product { id = 6, name = "Chinos", price = 499, description = "Purple chinos made by cheap monday", category = "Pants" });
            

            return ProductList;
        }

        public void AddingProducts()
        {
            Console.WriteLine("What ID will the new product have?");
            int Addid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the name of the product?");
            string Addname = Console.ReadLine();
            Console.WriteLine("And the price?");
            int Addprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The product will also need a description: ");
            string Adddescription = Console.ReadLine();
            Console.WriteLine("What category does it belong in?");
            string Addcategory = Console.ReadLine();
            Products().Add(new Product { id = Addid, name = Addname, price = Addprice, description = Adddescription, category = Addcategory });

            string[] TempArray = new string[diffCats.Length + 1];
            for (int i = 0; i < diffCats.Length; i++)
            {
                TempArray[i] = diffCats[i];
            }
            TempArray[TempArray.Length - 1] = Addcategory;
            diffCats = TempArray;
        }

        //public void RemoveProducts()
        //{

        //    Console.WriteLine("Enter the product ID of the product you want to remove");

        //    string[] TempArray = new string[diffCats.Length + 1];
        //    for (int i = 0; i < diffCats.Length; i++)
        //    {
        //        TempArray[i] = diffCats[i];
        //    }
        //    TempArray[TempArray.Length - 1] = Addcategory;
        //    diffCats = TempArray;
        //}

        public string PrintProducts() // All info om produkt
        {
            return "\nID: " + this.id + "\nName: " + this.name + "\nPrice: " + this.price + ":-" + "\nDescription: " + this.description + "\nCategory: " + this.category;
        }
        public string PrintCategory() // Kategorier
        {
            return this.category;
        }
        public string PrintName() // Namn på produkter
        {
            return this.name;
        }
    }
}
