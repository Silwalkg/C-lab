using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace labsheet2.q3
{
    public class TemperatureTracker
    {
        private const int DaysInWeek = 7;
        private double[] temperatures;

        public TemperatureTracker() 
        {
            temperatures = new double[DaysInWeek];
        }
        public void InputTemperatures()
        {
            for (int i = 0; i < DaysInWeek; i++) 
            {
                Console.WriteLine($"Enter the temperature for day {i + i}:");
                string input = Console.ReadLine();

                // Input validation using a loop ensures proper data entry
                if (!double.TryParse(input, out temperatures[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--; // Decrement i to repeat input for the same day
                }
            }
        }
        public void Main(string[] args)
        {
            Console.WriteLine("\nWeekly Temperature Report:");
            // Use LINQ for concise formatting and conditional checks
            var summary = temperatures.Select((temp, index) =>
                $"\tDay {index + 1}: {temp:N2}°C" + (temp >= 25 ? " (Warm)" : ""));

            Console.WriteLine(string.Join("\n", summary));

            Console.WriteLine("\nAdditional statistics:");
            Console.WriteLine($"\tAverage temperature: {temperatures.Average():N2}°C");
            Console.WriteLine($"\tHighest temperature: {temperatures.Max():N2}°C");
            Console.WriteLine($"\tLowest temperature: {temperatures.Min():N2}°C");
        }
    }
}
