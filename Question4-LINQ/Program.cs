// ------------------------------------------------------------
// Program: Filter employees with salary > 50,000 using LINQ
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amit", Salary = 40000 },
            new Employee { Id = 2, Name = "Neha", Salary = 60000 },
            new Employee { Id = 3, Name = "Raj", Salary = 70000 }
        };

        // LINQ query to filter employees
        var highSalaryEmployees = employees.Where(emp => emp.Salary > 50000);

        // Display filtered results
        Console.WriteLine("Employees with Salary > 50000:");
        foreach (var emp in highSalaryEmployees)
        {
            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
        }
    }
}