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

        public List<Product> Products() // Skapar listan med alla produkter
        {
            List<Product> Products = new List<Product>();
            Products.Add(new Product { id = 1, name = "Business Shirt", price = 799, description = "A white business shirt made from cotton by Ralph Lauren", category = "Shirts" });
            Products.Add(new Product { id = 2, name = "Winter hat", price = 549, description = "A black winter hat made with yarn", category = "Hats" });
            Products.Add(new Product { id = 3, name = "Jeans", price = 799, description = "Blue ragged jeans made by JC", category = "Pants" });
            Products.Add(new Product { id = 4, name = "Cardigan", price = 4999, description = "Scarlet cardigan by Lacoste", category = "Sweaters" });
            Products.Add(new Product { id = 5, name = "Sunglasses", price = 1999, description = "Polarized lenses made by Ray-Ban", category = "Glasses" });
            Products.Add(new Product { id = 6, name = "Chinos", price = 499, description = "Purple chinos made by cheap monday", category = "Pants" });

            return Products;
        }

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
