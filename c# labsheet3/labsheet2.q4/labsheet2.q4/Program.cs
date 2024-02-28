using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet2.q4
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        // Parameterized constructor to initialize properties
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }

        // Method to display product details
        public void DisplayDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: ${Price:F2}");
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create product objects with different names and prices
            Product product1 = new Product("T-Shirt", 19.99);
            Product product2 = new Product("Shirt", 20.50);

            // Display details of each product
            product1.DisplayDetails();
            product2.DisplayDetails();
        }
    }
}
