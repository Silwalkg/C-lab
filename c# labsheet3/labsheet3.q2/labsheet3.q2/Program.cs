using System;

public class Employee
{
    private int _employeeId;
    private string _fullName;
    private double _salary;

    public Employee(int employeeId, string fullName, double salary)
    {
        _employeeId = employeeId;
        _fullName = fullName;
        _salary = salary;
    }

    public int EmployeeId => _employeeId; // Read-only property for employee ID

    public string FullName
    {
        get => _fullName;
        set => _fullName = value;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}");
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Salary: ${_salary}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // (a) Create an employee instance
        Employee employee = new Employee(101, "John Doe", 50000);

        // (b) Access and display the employee ID
        Console.WriteLine($"Employee ID: {employee.EmployeeId}");

        // (c) Update the full name
        employee.FullName = "Jane Smith";

        // (d) Attempt to modify salary directly (outside the class)
        // employee._salary = 60000; // This will cause a compilation error!

        // Display updated information
        employee.DisplayInfo();
    }
}
