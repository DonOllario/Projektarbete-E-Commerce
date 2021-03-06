﻿using System;
using System.Collections.Generic;

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
        

        public ProductLine() //Skapar kundkorgsraden
        {
            Product ChosenProduct = GetProductForCart(Product.ProductList); // Hämtar artikeln som ska läggas till.
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
            Console.WriteLine("\n-Type in the wanted product ID.");
            while (true)
            {
                int prodID;
                try
                {
                    prodID = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    prodID = 0;
                }
                
                if (prodID >= 1 && prodID <= Products.Count)
                {
                    
                    for (int i = 0; i < Products.Count; i++)
                    {
                        if (Products[i].id.Equals(prodID))
                        {
                            ProductForCart = Products[i];
                        }
                    }
                    return ProductForCart;
                }
                else
                {
                    Console.WriteLine("Incorrect ID, please try again");
                }
            }
         
        }

        public int GetProductLineQuantity() 
        {
            Console.WriteLine("\n-How many would you like to buy?");
            while (true)
            {
                int quantity;
                try
                {
                    quantity = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    quantity = 0;
                }
                if (quantity != 0)
                {
                    return quantity;
                }
                else
                {
                    Console.WriteLine("Incorrect quantity, please try again");
                }
            }
        }

        public string PrintProductLine()
        {
            return "\nID: " + ID + "\nName: " + ProductName + "\nPrice: " + Price + ":-" + "\nDescription: " + Description + "\nCategory: " + Category + "\n\nQuantity: " + Quantity + "\nProduct Total: " + PricePerLine + ":-";
        }

    }
}
