using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1.q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to display its multiplication table:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplicaton table of {0}:", n);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            }
            Console.WriteLine();
        }
    }
}
