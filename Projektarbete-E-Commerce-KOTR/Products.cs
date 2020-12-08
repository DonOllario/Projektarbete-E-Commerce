using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class Products
    {
        public string id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string[] difcats = { "Shirts", "Pants", "Sweaters", "Accessories", "Hats" };
        public List<string> Categories = new List<string>();

        private List<Products> Clothes = new List<Products>();

        public List<Products> GetList()
        {
            return Clothes;
        }
        public string PrintProducts() // All info om produkt
        {
            return"\nName: " + this.name +"\nPrice: " + this.price + "\nDescription: " + this.description;
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
