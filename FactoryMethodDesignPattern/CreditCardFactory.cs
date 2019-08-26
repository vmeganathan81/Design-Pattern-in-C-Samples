using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.FactoryMethodDesignPattern
{
    public class CreditCardFactory
    {
        public ICreditCard CreateObject(int CreditCardType)
        {
            ICreditCard product = null;

            if (CreditCardType == 1)
            {
                product = new PlatinumCreditCardFactory().CreateProduct();
            }
            else if (CreditCardType == 2)
            {
                product = new TitaniumCreditCardFactory().CreateProduct();
            }

            return product;
        }
    }
}
