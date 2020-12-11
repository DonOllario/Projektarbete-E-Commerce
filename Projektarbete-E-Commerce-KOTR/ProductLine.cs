using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class ProductLine
    {
        public double PricePerLine;
        public int Quantity;
        public string ProductName;
        public int ID;
        public double Price;
        public string Description;
        public string Category;

        Product ProductReference = new Product();
        

        public ProductLine() //Skapar kundkorgsraden
        {
            Product ChosenProduct = GetProductForCart(ProductReference.Products()); // Hämtar artikeln som ska läggas till.
            Quantity = GetProductLineQuantity();
            PricePerLine = Quantity * ChosenProduct.price;
            ProductName = ChosenProduct.name;
            ID = ChosenProduct.id;
            Description = ChosenProduct.description;
            Price = ChosenProduct.price;
            Category = ChosenProduct.category;
            
        }

        public Product GetProductForCart(List<Product> Products)
        {
            Product ProductForCart = new Product();
            Console.WriteLine("Type in the wanted product ID.");
            int prodID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].id.Equals(prodID))
                {
                    ProductForCart = Products[i];
                }
            }
            return ProductForCart;
        }

        public int GetProductLineQuantity() 
        {
            Console.WriteLine("How many would you like to buy?");
            int quantity = int.Parse(Console.ReadLine());
            return quantity;
             
        }

        public string PrintProductLine()
        {
            return "\nID: " + ID + "\nName: " + ProductName + "\nPrice: " + Price + ":-" + "\nDescription: " + Description + "\nCategory: " + Category + "\n\nQuantity: " + Quantity + "\nProduct Total: " + PricePerLine;
        }

        public void RemoveProduct(List<Product> ProductLines)
        {
            Console.WriteLine("Enter the ID of the product you want to remove.");
            int prodID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ProductLines.Count; i++)
            {
                if (ProductLines[i].id.Equals(prodID))
                {
                    Console.WriteLine("Enter the quantity you want to remove.");
                    ProductReference.quantity = Convert.ToInt32(Console.ReadLine());
                    ProductReference.LinePrice = ProductLines[i].price * ProductReference.quantity;

                    ProductLines.Remove(ProductLines[i]);
                }
            }

        }
    }
}
