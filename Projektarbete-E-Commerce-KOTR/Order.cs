using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class Order
    {
        private double TotalPrice;
        private int OrderID = 1234567890;
        private string DeliveryAdress;
        private List<ProductLine> OrderLines;
        private bool Invoice = false;
        private bool CreditCard = false;
        private string NameOnCard;
        private string CreditCardNumber; //Är satt som string eftersom det är 16 nummer och det blir för stort för int.
        private string CVCcode; //Är också satt som string för att felhanteringen i metoden är samma som för CreditCardNumber. Se SetCVCcode
        private string NameOnInvoice;
        private string InvoiceAdress;
        private bool PaymentCheck;

        MenuHandler MyHandler = new MenuHandler();

        public Order(List<ProductLine> cartList, string accountAdress, string accountName) //Konstruktor som skapar en order Alla metoder körs internt.
        {
            MyHandler.ClearConsoleKOTRM();
            OrderID++; // Skapar ett nytt unikt ordernummer varje gång.
            OrderLines = cartList; // Tar all info från de ProductLine som finns i CartList, döper om dem till OrderLines för tydlighetens skull.
            TotalPrice = CalcTotalPrice(cartList); // Räknar ut totalpriset på ordern
            MyHandler.ClearConsoleKOTRM(); 
            if (accountAdress != null) // IF-sats som kollar om användaren är inloggad eller inte. Om man inte är det frågar programmet efter info som behövs.
            {
                DeliveryAdress = accountAdress;
            }
            else
            {
                SetDeliveryAdress();
            }
            while (PaymentCheck == false) // loopar sålänge betalningen inte gått igenom.
            {
                string payment = SetPaymentChoise(); //Ber användaren välja betalningsmetod
                if (payment == "1")
                {
                    NameOnCard = SetNameOnCard(); //Ber om kortnamn
                    CreditCardNumber = SetCreditCardNumber(); //Ber om kortnummer
                    CVCcode = SetCVCcode(); //Ber om cvc-koden
                    if (CheckAccountBalance(TotalPrice) == false)//Kollar med banken om det finns pengar på kortet eller inte
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("You dont have enough money on your card. Please try another payment method.");
                        Console.ReadKey();
                    }
                    else
                    {
                        CreditCard = true; //Sätter betalningsmetoden för ordern till kreditkort
                        PaymentCheck = true;
                    }
                }
                else if (payment == "2")
                {
                    NameOnInvoice = SetNameOnInvoice(accountName); //Ber fakturanamn om kunden inte är inloggad
                    InvoiceAdress = SetInvoiceAdress(accountAdress);//Ber om faktura adress, dubbelkollar om det är samma om man är inloggad
                    Invoice = true;//Sätter betalningsmetoden för ordern till faktura
                    PaymentCheck = true;
                }
            }
        }

        private double CalcTotalPrice(List<ProductLine> cartList)//Räknar ut totalpris
        {
            double totalPrice = 0;
            for(int i = 0; i < cartList.Count; i++)
            {
                totalPrice += cartList[i].PricePerLine;
            }
            return totalPrice;
        }

        private void SetDeliveryAdress()//Sätter leveransadressen
        {
            string adress;
            MyHandler.ClearConsoleKOTRM();
            Console.Write("Enter the delivery adress: ");
            adress = Console.ReadLine();
            DeliveryAdress = adress;
        }

        private string SetPaymentChoise()// Sätter betalningsmetoden
        {
            MyHandler.ClearConsoleKOTRM();
            Console.WriteLine("Choose your payment method.{0}1. Credit card.{0}2. Invoice.", Environment.NewLine);
            string paymentChoise = "0";
            while (paymentChoise != "1" && paymentChoise != "2")
            {
                paymentChoise = Console.ReadLine();
                if(paymentChoise != "1" && paymentChoise != "2")
                {
                    Console.WriteLine("You need to enter 1 or 2.");
                }
            }
            return paymentChoise;
        }
        private string SetNameOnCard()//Sätter kortnamn
        {
            MyHandler.ClearConsoleKOTRM();
            Console.WriteLine("Please enter the following information.");
            Console.Write("Name on card: ");
            string nameOnCard = Console.ReadLine();
            return nameOnCard;
        }
        private string SetCreditCardNumber()//Sätter kortnummer
        {
            string creditCardNumber = " ";
            while (creditCardNumber.Length != 16)//kollar så kortnummret är 16 nummer
            {
                Console.Write("Credit card number (16 digits and no spaces): ");
                creditCardNumber = Console.ReadLine();
                if(creditCardNumber.Length != 16)
                {
                    MyHandler.ClearConsoleKOTRM();
                    Console.WriteLine("You need to enter the number with 16 digits and no spaces. Press enter once and try again.");
                }
                else
                {
                    foreach(char c in creditCardNumber)
                    {
                        if(Char.IsLetter(c)) //Kollar så det bara är siffror man matar in
                        {
                            MyHandler.ClearConsoleKOTRM();
                            Console.WriteLine("Credit card numbers can only contain numbers. Press enter once and try again.");
                            break;
                        }
                    }
                }
            }
            return creditCardNumber;
        }
        private string SetCVCcode()
        {
            string cvcCode = " ";
            while(cvcCode.Length != 3)//Kollar så inmatningen är 3 siffror
            {
                Console.Write("CVC-code (3-digits): ");
                cvcCode = Console.ReadLine();
                if (cvcCode.Length != 3)
                {
                    MyHandler.ClearConsoleKOTRM();
                    Console.WriteLine("The CVC-code is 3 digits. Please try again.");
                }
                else
                {
                    foreach (char c in cvcCode)
                    {
                        if (Char.IsLetter(c))//Kollar så det bara är siffror man matar in
                        {
                            MyHandler.ClearConsoleKOTRM();
                            Console.WriteLine("CVC-codes can only contain numbers. Please try again.");
                            break;
                        }
                    }
                }
            }
            return cvcCode;
        }
        private string SetNameOnInvoice(string accountName)//Sätter fakturanamn och kollar om det är samma som användaren matat in
        {
            MyHandler.ClearConsoleKOTRM();
            string invoiceName;
            if(accountName == null)
            {
                Console.Write("Enter the name that should be put on the invoice: ");
                invoiceName = Console.ReadLine();
            }
            else
            {
                invoiceName = accountName;
            }
            return invoiceName;
        }
        private string SetInvoiceAdress(string accountAdress)// Sätter fakturaadress och kollar om det är samma som användaren matat in
        {
            string invoiceAdress;
            if (accountAdress == null)
            {
                Console.Write("Enter the adress that we should send the invoice too: ");
                invoiceAdress = Console.ReadLine();
            }
            else
            {
                invoiceAdress = accountAdress;
            }
            return invoiceAdress;
        }
        private bool CheckAccountBalance(double totalPrice) //kollar om man har pengar på kortet och returnerar true eller false.
        {
            Bank TheBank = new Bank();
            bool balance = TheBank.CheckPayment(totalPrice);
            return balance;
        }
        public void PrintReciept()
        {
            MyHandler.ClearConsoleKOTRM();
            Console.WriteLine($"Thank you for your order! The order number is: {OrderID}");
            Console.WriteLine("This is your reciept.");
            Console.WriteLine(" ");
            for(int p = 0; p < OrderLines.Count; p++)
            {
                Console.WriteLine($"ID: {OrderLines[p].ID} - {OrderLines[p].ProductName} - {OrderLines[p].Description} - Quantity: {OrderLines[p].Quantity} Price: {OrderLines[p].PricePerLine}:-");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Delivery adress: {DeliveryAdress}");
            Console.WriteLine(" ");
            Console.WriteLine($"Total price: {TotalPrice}:-");
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
