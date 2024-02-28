using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet3q1
{
    public class Program
    {
        private string _courseName;
        private string _instructorName;
        private double _grade;

        public string CourseName => _courseName; // Read-only property for course name

        public double Grade
        {
            get => _grade;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Grade must be between 0 and 100.");
                }
                _grade = value;
            }
        }
        public void SetInstructorName(string instructorName)
        {
            if (string.IsNullOrEmpty(instructorName))
            {
                throw new ArgumentException("Instructor name cannot be empty.");
            }
            _instructorName = instructorName;
        }
        private string CalculateLetterGrade()
        {
            if (_grade >= 90)
            {
                return "A";
            }
            else if (_grade >= 80)
            {
                return "B";
            }
            else if (_grade >= 70)
            {
                return "C";
            }
            else if (_grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        public void PrintCourseInfo()
        {
            string letterGrade = CalculateLetterGrade();
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Instructor Name: {_instructorName}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
        }

        public Course(string courseName, double grade)
        {
            _courseName = courseName;
            Grade = grade; // Calls the setter with validation
        }
    }
}
