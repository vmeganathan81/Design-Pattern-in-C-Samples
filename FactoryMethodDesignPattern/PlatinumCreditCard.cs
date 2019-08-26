using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.FactoryMethodDesignPattern
{
    //Concrete Product 
    public class PlatinumCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
