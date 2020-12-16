using System;
using System.Collections.Generic;

namespace Projektarbete_E_Commerce_KOTR
{
    class Product
    {
        //Start produkter
        public int id; 
        public string name;
        public double price;
        public string description;
        public string category;

        //Nya produkter
        public int Addid = 6; 
        public string Addname;
        public double Addprice;
        public string Adddescription;
        public string Addcategory;

        MenuHandler myMenu = new MenuHandler();

        public static string[] diffCats = { "Shirts", "Pants", "Glasses", "Sweaters", "Hats" };
        public static List<Product> ProductList = new List<Product>();
        

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

        public void AddProductAsAdmin() //Lägger till en ny produkt i produktlistan
        {
            Addid++;
            Console.WriteLine("Enter the name of the new product");
            Addname = Console.ReadLine();
            Console.WriteLine("Enter the price of the new product");
            Addprice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the description of the new product");
            Adddescription = Console.ReadLine();
            Console.WriteLine("Enter the category of the new product");
            Addcategory = Console.ReadLine();
            diffCats = AddCategoryToArray(Addcategory); // Lägger till en kategori i diffCats
            ProductList.Add(new Product { id = Addid, name = Addname, price = Addprice, description = Adddescription, category = Addcategory });
            Console.WriteLine("\nYou have successfully added your new product to the e-commerce!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public string[] AddCategoryToArray(string Addcategory)
        {
            string[] TempArray = new string[diffCats.Length + 1]; //Lägger till i Arrayn av kategorier
            for (int i = 0; i < diffCats.Length; i++)
            {
                TempArray[i] = diffCats[i];
            }
            TempArray[TempArray.Length - 1] = Addcategory;
            diffCats = TempArray;
            return diffCats;
        }

        public void RemoveProductAsAdmin(List<Product> Products) 
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine(Products[i].PrintProducts());
            }
            Console.WriteLine("\n**********************\nEnter the product id of the product you want to remove");
            int prodIDtoremove = Convert.ToInt32(Console.ReadLine());
            if (prodIDtoremove >= 1 && prodIDtoremove <= Products.Count)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].id.Equals(prodIDtoremove))
                    {
                        Products.Remove(Products[i]);
                        
                    }
                }
                Console.WriteLine("\nYou have successfully removed the product!");
            }
            else
            {
                Console.WriteLine("Incorrect ID, please try again");
            }
        }

        //public string[] RemoveCategoryFromArray(string removeCategory)
        //{

        //    Console.WriteLine("Enter the product ID of the product you want to remove");

        //    string[] TempArray = new string[diffCats.Length - 1];
        //    diffCats = TempArray;
        //    return diffCats;
        //}

        public void ChangeProductAsAdmin(List<Product> Products) 
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine(Products[i].PrintProducts());
            }

            Console.WriteLine("\nEnter the product ID of the product you want to edit");
            int prodIDedit = Convert.ToInt32(Console.ReadLine());
            if (prodIDedit >= 1 && prodIDedit <= Products.Count)
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].id.Equals(prodIDedit))
                    {
                        myMenu.ClearConsoleKOTRM();
                        Console.WriteLine(Products[i].PrintProducts());
                        Console.WriteLine("\nPlease type in one of the attribute you want to edit");
                        Console.WriteLine("-Name");
                        Console.WriteLine("-Price");
                        Console.WriteLine("-Description");
                        Console.WriteLine("-Category");
                        while (true)
                        {
                            var attributeInput = Console.ReadLine();
                            attributeInput = attributeInput.ToLower();
                            if (attributeInput == "name")
                            {
                                Console.WriteLine("Type in the new name for the product");
                                Products[i].name = Console.ReadLine();

                                break;
                            }
                            else if (attributeInput == "price")
                            {

                                double newPrice;
                                bool BreakingTheLoop = false;
                                Console.WriteLine("Type in the new price for the product");

                                while (!BreakingTheLoop)
                                {
                                    try
                                    {
                                        newPrice = Convert.ToDouble(Console.ReadLine());
                                    }
                                    catch (Exception)
                                    {

                                        newPrice = 0;
                                    }

                                    if (newPrice <= 0)
                                    {
                                        Console.WriteLine("Something went wrong please try again");
                                    }
                                    else
                                    {
                                        Products[i].price = newPrice;
                                        BreakingTheLoop = true;
                                    }
                                }
                                break;
                            }
                            else if (attributeInput == "category")
                            {
                                Console.WriteLine("Type in the new category for the product");
                                string CategoryInput = Console.ReadLine();
                                Products[i].category = CategoryInput;
                                diffCats = AddCategoryToArray(CategoryInput);
                                break;
                            }
                            else if (attributeInput == "description")
                            {
                                Console.WriteLine("Type in the new description for the product");
                                Products[i].description = Console.ReadLine();

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Something went wrong please try again");
                            }
                        }
                    }
                }
                Console.WriteLine("\nYou have successfully edited the product!");
                Console.WriteLine("Press any key to continue");
            }
            else
            {
                Console.WriteLine("Incorrect ID, please try again");
            }
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
