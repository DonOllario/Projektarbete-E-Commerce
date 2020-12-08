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
        /*public List<ProductLine> OrderLines;*/
        public bool Invoice = false;
        public bool CreditCard = false;
        public string NameOnCard;
        public int CreditCardNumber;
        public int CVCcode;
        public string NameOnInvoice;
        public string InvoiceAdress;

        public Order(/*List<ProductLine> productLines,*/ string userAdress, string userName, int shoppingCartID)
        {
            OrderID = shoppingCartID;
            /*OrderLines = productLines;*/
            /*CalcTotalPrice(productLines);*/
            if (userAdress != null)
            {
                DeliveryAdress = userAdress;
            }
            else
            {
                GetAdressFromUserThroughInput();
            }
            int payment = GetPaymentChoiseFromUser();
            if (payment == 1)
            {
                NameOnCard = GetNameOnCard();
                CreditCardNumber = GetCreditCardNumber();
                CVCcode = GetCVCcode();
                CheckAccountBalance(TotalPrice);
                CreditCard = true;
            }
            else if(payment == 2)
            {
                NameOnInvoice = GetNameOnInvoice(userName);
                InvoiceAdress = GetInvoiceAdress(userAdress);
                Invoice = true;
            }
        }

        /*public void CalcTotalPrice(List<ProductLine> productLines)
        {
            double totalPrice = 0;
            foreach (ProductLine p in productLines)
            {
                totalPrice += productLines[p].Price;
            }
            TotalPrice = totalPrice;
        }*/

        public void GetAdressFromUserThroughInput()
        {
            string adress;
            Console.Write("Vänligen ange leveransadressen: ");
            adress = Console.ReadLine();
            DeliveryAdress = adress;
        }

        public int GetPaymentChoiseFromUser()
        {
            Console.Clear();
            Console.WriteLine("Choose your payment method.{0}1. Credit card.{0}2. Invoice.", Environment.NewLine);
            int paymentChoise = 0;
            while (paymentChoise != 1 && paymentChoise != 2)
            {
                paymentChoise = int.Parse(Console.ReadLine());
                switch (paymentChoise)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You need to enter 1 or 2.");
                        break;
                }
            }
            return paymentChoise;
        }
        public string GetNameOnCard()
        {
            Console.WriteLine("Please enter the following information.");
            Console.Write("Name on card: ");
            string nameOnCard = Console.ReadLine();
            return nameOnCard;
        }
        public int GetCreditCardNumber()
        {
            int creditCardNumber = 0;
            while (Convert.ToString(creditCardNumber).Length != 16)
            {
                Console.Write("Credit card number: ");
                CreditCardNumber = int.Parse(Console.ReadLine());
                if (Convert.ToString(creditCardNumber).Length != 16)
                {
                    Console.Clear();
                    Console.WriteLine("You need to enter the number with 16 digits and no spaces. Press enter once and try again.");
                }
            }
            return creditCardNumber;
        }
        public int GetCVCcode()
        {
            int cvcCode = 0;
            while (Convert.ToString(cvcCode).Length != 3)
            {
                Console.Write("CVC-code: ");
                CVCcode = int.Parse(Console.ReadLine());
                if (Convert.ToString(cvcCode).Length != 3)
                {
                    Console.Clear();
                    Console.WriteLine("The CVC-code is 3 digits. Press enter once and try again.");
                }
            }
            return cvcCode;
        }
        public string GetNameOnInvoice(string userName)
        {
            string invoiceName;
            if(userName != null)
            {
                Console.Write("Enter the name that should be put on the invoice: ");
                invoiceName = Console.ReadLine();
            }
            else
            {
                invoiceName = userName;
            }
            return invoiceName;
        }
        public string GetInvoiceAdress(string userAdress)
        {
            string invoiceAdress;
            if (userAdress != null)
            {
                Console.Write("Enter the adress that we should sent the invoice too: ");
                invoiceAdress = Console.ReadLine();
            }
            else
            {
                invoiceAdress = userAdress;
            }
            return invoiceAdress;
        }
        public bool CheckAccountBalance(double totalPrice)
        {
            bool balance = false;
            Bank bank1 = new Bank();
            balance = bank1.CheckPayment(totalPrice);
            if (balance == false)
            {
                Console.WriteLine("You dont have enough money on you bank account. Please try another payment method.");
            }
            return balance;
        }
    }
}
