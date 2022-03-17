using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_Service_Engineer_II_Interview_Coding_Practice
{
    class Prime_Number_or_Not
    {
        public static void Main()
        {

            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }

            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("{0} Not a Prime Number", n);
            }
            Console.ReadLine();
        }
    }
}
