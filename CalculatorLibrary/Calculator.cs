using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    internal class Calculator
    {
        public int CalculatorAdd(int a, int b)
        {
            return a+b;
        }
        public int CalculatorSubtract(int a, int b)
        {
            return a-b;
        }
        public int CalculatorMultiply(int a, int b)
        {
            return a*b;
        }
        public int CalculatorDivide(int a, int b)
        {
            return a/b;
        }
    }
}
