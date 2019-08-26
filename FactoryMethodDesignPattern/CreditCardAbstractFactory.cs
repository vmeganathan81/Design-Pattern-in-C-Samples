using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.FactoryMethodDesignPattern
{
    public abstract class CreditCardAbstractFactory
    {
        //This method is going to be implemented by the sub classes
        protected abstract ICreditCard MakeProduct();
        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
