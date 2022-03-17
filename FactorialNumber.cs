using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_Service_Engineer_II_Interview_Coding_Practice
{
    class FactorialNumber
    {
        public static int Factorial(int number)
        {
            int value = 1;
            for (int i = 1; i <= number; i++)
            {
                value = value * i;
            }
            return value;
        }

        public static void Main()
        {
            Console.WriteLine("Enter a Number :");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Factorial of Number is {0} ", Factorial(number));

            Console.ReadLine();
        }

    }
}
