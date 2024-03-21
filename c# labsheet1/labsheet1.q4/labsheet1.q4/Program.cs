using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1.q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms (N): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("First {0} terms of Fibonacci series: ", n);
            PrintFibonacci(n);
            Console.WriteLine();
        }
        static void PrintFibonacci(int n)
        {
            if (n <= 0)
            {
                Console.Write("{0}", n);
            }
            else
            {
                PrintFibonacci(n - 1);
                Console.Write("{0}", n );
            }
        }
    }
}
