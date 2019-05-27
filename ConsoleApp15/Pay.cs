using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Pay
    {
        public string creditCardNumber;
        public int threeDigit;
        public int expirationDate;

        public Pay(string creditCardNumber, int threeDigit, int expirationDate)
        {
            this.creditCardNumber = creditCardNumber;
            this.threeDigit = threeDigit;
            this.expirationDate = expirationDate;
        }

        public string creditCardNumberP { get { return this.creditCardNumber; } set { this.creditCardNumber = value; } }
        public int threeDigitP { get { return this.threeDigit; } set { this.threeDigit = value; } }
        public int expirationDateP { get { return this.expirationDate; } set { this.expirationDate = value; } }




    }
}
