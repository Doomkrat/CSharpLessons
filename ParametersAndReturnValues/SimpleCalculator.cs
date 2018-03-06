using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAndReturnValues
{
    class SimpleCalculator
    {
        public int Square(int x)
        {
            return x * x;
        }

        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public int FindMaxOfThree(int a, int b, int c)
        {
            if (a >= b && a >= c)
                return a;
            else if (b >= a && b >= c)
                return b;
            else
                return c;

        }
    }
}
