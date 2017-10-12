using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_Practice
{
    class OperatorVsMethod
    {
         public static bool OperatorEquality(int x, int y)
        {
            return x == y;
        }

        public static bool MethodEquality(int x, int y)
        {
            return x.Equals(y);
        }
    }
}
