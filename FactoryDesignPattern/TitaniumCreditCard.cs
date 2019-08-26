using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.SimpleFactoryPattern
{
    public class TitaniumCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }

        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
