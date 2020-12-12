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
            Console.WriteLine("\n  ******************** \\O/ You have successfully added the product to the shopping cart! \\O/ ********************");
            Console.WriteLine("                                         Press any key to continue shopping.");
            Console.ReadKey();
            myMenu.GoBack();
        }

        public void RemoveFromCart()
        {
            //CartList.Remove();
        }

        public void PrintCart(List<ProductLine> cartList)
        {
            myMenu.ClearConsoleKOTRM();
            for (int i = 0; i < cartList.Count; i++)
            {
                Console.WriteLine(cartList[i].PrintProductLine());
            }
            double Total = 0;
            for (int i = 0; i < cartList.Count; i++)
            {
                Total = Total + cartList[i].PricePerLine;

            }
            Console.WriteLine("\n*****************************");
            Console.WriteLine($"\nShopping cart total: {Total}:-");
            Console.WriteLine("\n*****************************");

            Console.WriteLine("\n1. Checkout");
            Console.WriteLine("2. Go Back");
            while (true)
            {
                int input = 0;
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    input = 0;
                }
                if (input == 1)
                {
                    Checkout();
                    break;
                }
                else if (input == 2)
                {
                    //Go back
                    myMenu.GoBack();
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Input, Please try again");
                }
            }
        }

        public void Checkout()
        {
            Order MyOrder = new Order(CartList, null, null);
            MyOrder.PrintReciept();
            Console.WriteLine("\n**********************************************************************************\n\n-Press any key to continue shopping.");
            Console.ReadKey();
            myMenu.GoBack();
            CartList.Clear();
        }
    }
}
