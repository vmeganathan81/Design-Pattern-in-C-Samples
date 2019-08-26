using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.SwitchCaseReplacement
{
    public class Type1Entity : Entity
    {
        public override int GetNewValue(int newValue)
        {
            return 2 * newValue;
        }
    }
}
