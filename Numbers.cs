using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    internal class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int min;
            if (number1 < number2)
            {
                min = number1;
            }
            else
            {
                min = number2;
            }
            return min;
        }
        //overloading method
        public int FindMinimum(int number1, int number2, float number3)
        {
            int min;
            if ((number1 < number2) && (number1 < number3))
            {
                min = number1;
            }
            else if ((number2 < number3) && (number2 < number1))
            {
                min = number2;
            }
            else
            {
                min = (int)number3; // cast
            }
            return min;
        }
        public int FindMaximum(int number1, int number2)
        {
            int max;
            if (number1 > number2)
            {
                max = number1;
            }
            else
            {
                max = number2;
            }
            return max;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            int max;
            if ((number1 > number2) && (number1 > number3))
            {
                max = number1;
            }
            else if ((number2 > number3) && (number2 > number1))
            {
                max = number2;
            }
            else
            {
                max = (int)number3;
            }
            return max;
        }
    }
}
