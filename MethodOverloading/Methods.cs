using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool condition)
        {
            if (condition) 
            {
                if (num1 + num2 == 1)
                {
                    return Convert.ToString($"{num1 + num2} dollar");
                }
                else
                {
                    return Convert.ToString($"{num1 + num2} dollars");
                }
            }
            else
            {
                return Convert.ToString($"{num1 + num2}");
            }
        }
    }
}
