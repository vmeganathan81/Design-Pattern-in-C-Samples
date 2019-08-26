﻿using System;

namespace Sample
{
    /*
  *  Sealed ensures the class being inherited and
  *  object instantiation is restricted in the derived class
  */
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() =>new Singleton());
       
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        /*
         * Private constructor ensures that object is not
         * instantiated other than with in the class itself
         */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
