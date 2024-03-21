using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            // Get positive integer input from user with error handling
            do
            {
                Console.WriteLine("Enter a positive integer: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out number) || number <= 0)
                {
                    Console.WriteLine("ERROR: Please enter a positive integer.");
                    number = -1; // Ensure loop continues for invalid input
                }
            } while (number <= 0);

            // Calculate sum using a formula (efficient for large numbers)
            int sum = (number * (number + 1)) / 2;

            // Display the sum
            Console.WriteLine("The sum of positive integers from 1 to {0} is: {1}", number, sum);
        }
    }
}
