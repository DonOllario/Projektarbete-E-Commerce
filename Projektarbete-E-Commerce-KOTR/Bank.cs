using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class Bank
    {
        private double AccountBalance = 10000;

        public bool CheckPayment(double totalPrice)
        {
            bool paymentOkOrNot;
            if(totalPrice >= AccountBalance)
            {
                paymentOkOrNot = false;
                return paymentOkOrNot;
            }
            else
            {
                paymentOkOrNot = true;
                return paymentOkOrNot;
            }
        }
    }
}
