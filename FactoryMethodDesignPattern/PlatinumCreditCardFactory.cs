using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.FactoryMethodDesignPattern
{
    public class PlatinumCreditCardFactory : CreditCardAbstractFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new PlatinumCreditCard();

            //Do something with the object once you get the object. 
            return product;
        }
    }
}
