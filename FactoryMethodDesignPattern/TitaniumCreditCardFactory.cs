using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.FactoryMethodDesignPattern
{
    public class TitaniumCreditCardFactory : CreditCardAbstractFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new TitaniumCreditCard();

            //Do something with the object once you get the object. 
            return product;
        }
    }
}
