using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1.q7
{
    internal class Program
    {
        static double balance = 1000; // Initial balance
        static void Main(string[] args)
        {
            int pin;
            Console.Write("Enter your PIN: ");
            pin = int.Parse(Console.ReadLine());

            if (pin == 1234) // Replace with a secure authentication mechanism
            {
                bool exit = false;
                while (!exit)
                {
                    DisplayMenu();
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            CheckBalance();
                            break;
                        case 2:
                            Deposit();
                            break;
                        case 3:
                            Withdraw();
                            break;
                        case 4:
                            exit = true;
                            Console.WriteLine("Thank you for using the ATM.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN. Please try again.");
            }
            void DisplayMenu()
            {
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
            }
            void CheckBalance()
            {
                Console.WriteLine("Your current balance is: {0:C}", balance);
            }

            void Deposit()
            {
                double amount;
                Console.Write("Enter amount to deposit: ");
                amount = double.Parse(Console.ReadLine());
                balance += amount;
                Console.WriteLine("Deposit successful. New balance: {0:C}", balance);
            }
            void Withdraw()
            {
                double amount;
                Console.Write("Enter amount to withdraw: ");
                amount = double.Parse(Console.ReadLine());
                if (amount > balance)
                {
                    Console.WriteLine("Insufficient funds.");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal successful. New balance: {0:C}", balance);
                }
            }
        }
    }
}
