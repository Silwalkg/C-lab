using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet2.q5
{
    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"{Title} by {Author} has been borrowed successfully!");
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} is currently unavailable.");
            }
        }

        public override string ToString()
        {
            return $" - {Title} by {Author} ({(Available ? "Available" : "Unavailable")})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create some book objects
            LibraryBook book1 = new LibraryBook("The Lord of the Rings", "J.R.R. Tolkien", true);
            LibraryBook book2 = new LibraryBook("Pride and Prejudice", "Jane Austen", true);
            LibraryBook book3 = new LibraryBook("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", false);

            // Display initial library status
            Console.WriteLine("**Library Books:**");
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
            Console.WriteLine();

            // Borrow book1
            book1.BorrowBook();
            Console.WriteLine();

            // Display updated library status
            Console.WriteLine("**Updated Library Status:**");
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
        }
    }
}
