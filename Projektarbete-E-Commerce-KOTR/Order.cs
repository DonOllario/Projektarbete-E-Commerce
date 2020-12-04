using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class Order
    {
        public double TotalPrice;
        public int OrderID;
        public string DeliveryAdress;

        public Order(ProductLine[] productLines, string userAdress)
        {
            OrderID = OrderID++;
            CalcTotalPrice(productLines);
            if (userAdress != null)
            {
                DeliveryAdress = userAdress; ;
            }
            else
            {
                GetAdressFromUserThroughInput();
            }
        }

        public void CalcTotalPrice(ProductLine[] productLine)
        {
            double totalPrice = 0;
            for (int i = 0; i < productLine.Length; i++)
            {
                totalPrice += productLine[i].Price;
            }
            TotalPrice = totalPrice;
        }

        public void GetAdressFromUserThroughInput()
        {
            string adress;
            Console.Write("Vänligen ange leveransadressen: ");
            adress = Console.ReadLine();
            DeliveryAdress = adress;
        }
    }
}
