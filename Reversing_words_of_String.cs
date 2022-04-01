using System;
namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Eneter the String:");

            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            Array.Reverse(a);

            Console.WriteLine("Reverse String is:");
            for (int i = 0; i <= a.Length - 1; i++)
            {

                Console.Write(a[i] + "" + ' ');
            }
            Console.ReadKey();
        }
    }
}