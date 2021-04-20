using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployeeInfo();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }
        static List<Employee> GetEmployeeInfo()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Please enter First Name: ");
                // Get first name
                string empFirstName = Console.ReadLine();

                Console.WriteLine("Please enter Last Name: ");
                // Get last name
                string empLastName = Console.ReadLine();

                Console.WriteLine("Please enter Photo URL: ");
                // Get photo url
                string empPhotoUrl = Console.ReadLine();

                Console.WriteLine("Please enter Employee ID: ");
                // Get employee id (and convert to integer)
                int empId = Int32.Parse(Console.ReadLine());


                // Create a new Employee instance
                Employee employee = new Employee(empFirstName, empLastName, empId, empPhotoUrl);
                employees.Add(employee);

                Console.WriteLine("Enter another employee? (y/n):");
                // run again?
                string goAgain = Console.ReadLine();
                // Break if the user enters 'n'
                if (goAgain == "n")
                {
                    break;
                }

            }
            return employees;
        }
    }
}
