using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.SimpleFactoryPattern
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
