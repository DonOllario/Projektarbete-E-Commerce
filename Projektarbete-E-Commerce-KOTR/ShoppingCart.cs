using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class ShoppingCart
    {
        string CartID { get; }
        int DateAdded { get; set; }

        MenuHandler myMenu = new MenuHandler();
        public List<ProductLine> CartList = new List<ProductLine>();
        private static int CartIDSeed = 1234567890;

        public ShoppingCart() 
        {
            CartID = CartIDSeed.ToString();
            CartIDSeed++;
        }

        public void AddProductLine()//Addera den produkt användaren har valt till CartList.
        {
            CartList.Add(new ProductLine());
            myMenu.ClearConsoleKOTRM();
            Console.WriteLine("You have added the product successfully to the shopping cart!");
        }

        

        public void RemoveFromCart()
        {
            //CartList.Remove();
        }

        public void PrintCart(List<ProductLine> cartList)
        {
            for (int i = 0; i < cartList.Count; i++)
            {
                Console.WriteLine(cartList[i].PrintProductLine());
            }
            Console.WriteLine("\n 1. Checkout");
            Console.WriteLine("\n 2. Go Back");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Checkout();
            }
            else if (input == 2)
            {
                //Go back
            }
            else
            {
                Console.WriteLine("Incorrect Input, Please try again");
            }
        }

        public void Checkout()
        {
            //Gå vidare till Order
        }
    }
}
