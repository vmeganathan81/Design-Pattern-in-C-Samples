using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    public class SwitchCase
    {
        public string Type { get; set; }

        public int GetNewValueBasedOnType(int newValue)
        {
            int returnValue = 0;
            switch (Type)
            {
                case "Type0":
                    returnValue = newValue;
                    break;
                case "Type1":
                    returnValue = newValue * 2;
                    break;
                case "Type2":
                    returnValue = newValue * 3;
                    break;
            }

            return returnValue;
        }
    }
}

