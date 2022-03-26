using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_Service_Engineer_II_Interview_Coding_Practice
{
    class TestPage
    {

        //public static int AddNums(int x, int y)
        //{
        //    return x - (-y);
        //}

        public static int MulWithOutStarOperator(int x, int y)
        {
            int value = 0;
            for (int z = 1; z <= y; z++)
            {
                value = value + x;
            }
            return value;
        }

        //public static void Main()
        //{
        //    Console.WriteLine("Enter First Number :");
        //    int num1 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter Second Number :");
        //    int num2 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Sum of multi number is {0}", MulWithOutStarOperator(num1, num2));
        //    Console.ReadLine();
        //}
    }
}
