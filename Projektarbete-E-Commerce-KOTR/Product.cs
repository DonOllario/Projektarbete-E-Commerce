using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string[] difcats = { "Shirts", "Pants", "Glasses", "Sweaters", "Hats" };
        public List<string> Categories = new List<string>();

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
