using SFMDP = Sample.FactoryMethodDesignPattern;
using Sample.FactoryPattern;
using Sample.SimpleFactoryPattern;
using System;
using System.Threading.Tasks;
using Sample.SwitchCaseReplacement;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Singleton--------------");

            //Singleton
            Parallel.Invoke(
                () => PrintStudentDetails(),
                () => PrintEmployeeDetails()
            );
            Console.WriteLine("--------------");

            //Simple Factory Design Pattern
            Console.WriteLine("--------------Simple Factory Design Pattern--------------");

            int cardType = 1;
            ICreditCard cardDetails = CardFactory.GetCardInstance(cardType); ;
            
          
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");

            //Simple Factory Method Design Pattern
            Console.WriteLine("--------------Simple Factory Method Design Pattern--------------");

            SFMDP.ICreditCard CreditCardInstance = new SFMDP.PlatinumCreditCardFactory().CreateProduct();
            if (CreditCardInstance != null)
            {
                Console.WriteLine("CardType : " + CreditCardInstance.GetCardType());
                Console.WriteLine("CreditLimit : " + CreditCardInstance.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + CreditCardInstance.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            CreditCardInstance = new SFMDP.TitaniumCreditCardFactory().CreateProduct();
            if (CreditCardInstance != null)
            {
                Console.WriteLine("CardType : " + CreditCardInstance.GetCardType());
                Console.WriteLine("CreditLimit : " + CreditCardInstance.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + CreditCardInstance.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }

            Console.WriteLine("--------------Providing another layer of Abstraction--------------");

            //Providing another layer of Abstraction:
            // In the above example, we directly call the CreateProduct method on a particular factory class instance to get the actual product instance.What if I need to create the product instance based on the card type value that I received from the user.If this is your requirement, then you need to create another simple factory class as shown below.Create a class with the name CreditCardFactory and then copy and paste the following code.

            //Setting the Card Type value 
            int CreditCardType = 1;
         
            //This is going to return an instance of a Particular Card type object 
            CreditCardInstance = new SFMDP.CreditCardFactory().CreateObject(CreditCardType);
            if (CreditCardInstance != null)
            {
                Console.WriteLine("CardType : " + CreditCardInstance.GetCardType());
                Console.WriteLine("CreditLimit : " + CreditCardInstance.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + CreditCardInstance.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");

            Console.WriteLine("------Abolish Switch Case--------");
            SwitchCase switchCase = new SwitchCase();
            switchCase.Type = "Type0";
            Console.WriteLine($"Type :: {switchCase.Type} Value :: {switchCase.GetNewValueBasedOnType(1)}");
            switchCase.Type = "Type1";
            Console.WriteLine($"Type :: {switchCase.Type} Value :: {switchCase.GetNewValueBasedOnType(1)}");
            switchCase.Type = "Type2";
            Console.WriteLine($"Type :: {switchCase.Type} Value :: {switchCase.GetNewValueBasedOnType(1)}");

            var entityFactory = new EntityFactory();
            var entity = entityFactory.GetEntityBasedOnType(EntityType.Type0);
            var result = entity.GetNewValue(1);
            Console.WriteLine(result);
            entity = entityFactory.GetEntityBasedOnType(EntityType.Type1);
            result = entity.GetNewValue(1);
            Console.WriteLine(result);
            entity = entityFactory.GetEntityBasedOnType(EntityType.Type2);
            result = entity.GetNewValue(1);
            Console.WriteLine(result);
            Console.WriteLine("--------------");
            Console.ReadLine();

        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}

