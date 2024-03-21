using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1.q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            int examMarks;

            Console.Write("Enter student name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter exam marks (out of 100): ");
            while (!int.TryParse(Console.ReadLine(), out examMarks) || examMarks < 0 || examMarks > 100) 
            {
                Console.WriteLine("Invoid marks,please enter a value between 0 and 100.");
                Console.Write("Enter exam marks (out of 100): ");
            }
            string grade;
            if  (examMarks > 75) 
            {
                grade = "A";
            }
            else if (examMarks >= 60) 
            {
                grade = "B";
            }
            else if (examMarks >= 50) 
            {
                grade = "C";
            }
            else if (examMarks >=40) 
            {
                grade = "D";
            }
            else
            {
                grade= "Fail";
            }
            Console.WriteLine(studentName+"'s final grade is: "+grade);
            Console.ReadLine();
        }
    }
}
