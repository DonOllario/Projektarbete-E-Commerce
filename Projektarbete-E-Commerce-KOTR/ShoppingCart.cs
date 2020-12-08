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

        public Products OurProducts;
        public HandleProducts HandleCartProducts;
        List<Products> CartList = new List<Products>();

        private static int CartIDSeed = 1234567890;

        public ShoppingCart() 
        {
            this.CartID = CartIDSeed.ToString();
            CartIDSeed++;
        }

        public void AddToCart()//Addera den produkt användaren har valt till CartList.
        {
            List<Products> ProductsForCart = OurProducts.GetList(); // Skapar hela listan av produkter till denna metoden/klassen. Så att den vet vilka produkter det handlar om.
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
        }

        public void RemoveFromCart(Products RemoveThisProduct)
        {
            CartList.Remove(RemoveThisProduct);
        }

        /*public List<Products> GetCart()
        {
            for (int i = 0; i < CartList.Length; i++)
            {
                return Console.WriteLine(CartList[i]);
            };
        }*/

        public void Checkout()
        {
            //Gå vidare till Order
        }
    }
}
