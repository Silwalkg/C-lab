using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for length
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());

            // Prompt user for width
            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            // Calculate area using separate function
            double area = CalculateArea(length, width);

            // Display the area
            Console.WriteLine("The area of the rectangle is: {0}", area);
        }

        static double CalculateArea(double length, double width)
        {
            // Function to calculate area
            return length * width;
        }
    }
}
