using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public static string Add(int number1, int number2, bool isCheck)
        {
            var sum = number1 + number2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
