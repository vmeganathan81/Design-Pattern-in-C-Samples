using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.FactoryMethodDesignPattern
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
