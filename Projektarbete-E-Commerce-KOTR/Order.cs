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
        public string OrderID;
        public string DeliveryAdress;
        public List<Product> OrderLines;
        public bool Invoice = false;
        public bool CreditCard = false;
        public string NameOnCard;
        public string CreditCardNumber;
        public string CVCcode;
        public string NameOnInvoice;
        public string InvoiceAdress;

        public Order(List<Product> cartList, string userAdress, string userName, string cartID)
        {
            OrderID = cartID;
            OrderLines = cartList;
            TotalPrice = CalcTotalPrice(cartList);
            Console.Clear();
            if (userAdress != null)
            {
                DeliveryAdress = userAdress;
            }
            else
            {
                SetDeliveryAdress();
            }
            int payment = SetPaymentChoise();
            if (payment == 1)
            {
                NameOnCard = SetNameOnCard();
                CreditCardNumber = SetCreditCardNumber();
                CVCcode = SetCVCcode();
                CheckAccountBalance(TotalPrice);
                CreditCard = true;
            }
            else if(payment == 2)
            {
                NameOnInvoice = SetNameOnInvoice(userName);
                InvoiceAdress = SetInvoiceAdress(userAdress);
                Invoice = true;
            }
        }

        public double CalcTotalPrice(List<Product> cartList)
        {
            double totalPrice = 0;
            for(int i = 0; i < cartList.Count; i++)
            {
                totalPrice += cartList[i].price;
            }
            return totalPrice;
        }

        public void SetDeliveryAdress()
        {
            string adress;
            Console.Clear();
            Console.Write("Enter the delivery adress: ");
            adress = Console.ReadLine();
            DeliveryAdress = adress;
        }

        public int SetPaymentChoise()
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
        public string SetNameOnCard()
        {
            Console.Clear();
            Console.WriteLine("Please enter the following information.");
            Console.Write("Name on card: ");
            string nameOnCard = Console.ReadLine();
            return nameOnCard;
        }
        public string SetCreditCardNumber()
        {
            string creditCardNumber = " ";
            while (creditCardNumber.Length != 16)
            {
                Console.Write("Credit card number (16 digits and no spaces): ");
                creditCardNumber = Console.ReadLine();
                if(creditCardNumber.Length != 16)
                {
                    Console.Clear();
                    Console.WriteLine("You need to enter the number with 16 digits and no spaces. Press enter once and try again.");
                }
                else
                {
                    foreach(char c in creditCardNumber)
                    {
                        if(Char.IsLetter(c))
                        {
                            Console.Clear();
                            Console.WriteLine("Credit card numbers can only contain numbers. Press enter once and try again.");
                            break;
                        }
                    }
                }
            }
            return creditCardNumber;
        }
        public string SetCVCcode()
        {
            string cvcCode = " ";
            while(cvcCode.Length != 3)
            {
                Console.Write("CVC-code (3-digits): ");
                cvcCode = Console.ReadLine();
                if (cvcCode.Length != 3)
                {
                    Console.Clear();
                    Console.WriteLine("The CVC-code is 3 digits. Please try again.");
                }
                else
                {
                    foreach (char c in cvcCode)
                    {
                        if (Char.IsLetter(c))
                        {
                            Console.Clear();
                            Console.WriteLine("CVC-codes can only contain numbers. Please try again.");
                            break;
                        }
                    }
                }
            }
            return cvcCode;
        }
        public string SetNameOnInvoice(string userName)
        {
            string invoiceName;
            if(userName == null)
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
        public string SetInvoiceAdress(string userAdress)
        {
            string invoiceAdress;
            if (userAdress == null)
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
            Bank TheBank = new Bank();
            bool balance = TheBank.CheckPayment(totalPrice);
            if (balance == false)
            {
                Console.WriteLine("You dont have enough money on you bank account. Please try another payment method.");
            }
            return balance;
        }
        public void PrintReciept()
        {
            Console.Clear();
            Console.WriteLine($"Thank you for your order {OrderID}!");
            for(int p = 0; p < OrderLines.Count; p++)
            {
                Console.WriteLine(OrderLines[p]);
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Delivery adress: {DeliveryAdress}");
            Console.WriteLine(" ");
            string payment = " ";
            if(Invoice == true)
            {
                payment = "Invoice";
            }
            else if(CreditCard == true)
            {
                payment = "Credit Card";
            }
            Console.WriteLine($"Payment: {payment}");
        }
    }
}
