using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet2.q1
{
    class book
    {
        public string Title { get; set; } 
        public string Author { get; set; } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creat a new Book Object
            book book = new book();

            //set values for the properties
            book.Title = "Harry Potter";
            book.Author = "J.K Rowling";

            //Display the information 
            Console.WriteLine("Title: {0}",book.Title);
            Console.WriteLine("Author: {0}",book.Author);

        }
    }
}
