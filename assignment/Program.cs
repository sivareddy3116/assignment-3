using System;

namespace EmployeeDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input employee details
            Console.Write("Enter Employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter Employee Gender (M/F): ");
            char employeeGender = char.Parse(Console.ReadLine());

            Console.Write("Enter Employee Salary: ");
            double employeeSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter Date of Joining (DD/MM/YYYY): ");
            DateTime dateOfJoining = DateTime.Parse(Console.ReadLine());

            // Calculate tax
            double taxRate = employeeSalary > 90000 ? 0.30 : 0.15;
            double taxAmount = employeeSalary * taxRate;

            // Display employee details
            Console.WriteLine("ID\tEmployee Name\tEmployee Gender\tEmployee Salary\tDOJ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{employeeId}\t{employeeName}\t\t{employeeGender}\t\t{employeeSalary:C}\t\t{dateOfJoining:dd/MM/yyyy}");
            Console.WriteLine();
            Console.WriteLine("You have to pay: " + taxAmount.ToString("C"));

            Console.ReadLine(); // Keep the console window open
        }
    }
}
