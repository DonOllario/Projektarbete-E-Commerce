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
        int quantity { get; set; }
        int dateAdded { get; set; }

        public Product OurProducts = new Product();
        public HandleProducts HandleCartProducts = new HandleProducts();
        List<Product> CartList = new List<Product>();

        private static int CartIDSeed = 1234567890;

        public ShoppingCart() 
        {
            this.CartID = CartIDSeed.ToString();
            CartIDSeed++;
        }

        /*public void AddToCart()//Addera den produkt användaren har valt till CartList.
        {
            // Hämtar hela listan av produkter till denna metoden/klassen. Så att den vet vilka produkter det handlar om.
            string idSearch = HandleCartProducts.GetidSearch(); // Hämtar den senaste specifikt valda produkten.
            //Console.WriteLine("Quantity");
            //int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ProductsForCart.Count; i++) // Adderar 
            {
                if (ProductsForCart[i].category.Equals(idSearch))
                {
                    CartList.Add(ProductsForCart[i]);
                }
            }
            CartList.ForEach(Console.WriteLine);
        }*/

        public void RemoveFromCart()
        {
            //CartList.Remove();
        }

        public void GetCart(/*CartList*/)
        {
            CartList.ForEach(Console.WriteLine);
        }

        public void Checkout()
        {
            //Gå vidare till Order
        }
    }
}
