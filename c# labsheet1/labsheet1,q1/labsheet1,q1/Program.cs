﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("\nEnter a number: ");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("It's a even");
                }
                else
                {
                    Console.WriteLine("It's a odd");
                }
            }
            Console.ReadLine();
        }
    }
}

