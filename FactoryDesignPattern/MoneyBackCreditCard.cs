﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.SimpleFactoryPattern
{
    public class MoneyBackCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
