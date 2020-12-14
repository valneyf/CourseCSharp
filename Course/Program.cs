using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> Employees = new List<Employee>(n);

            for (int i = 1; i <= n; i++)
            {                
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char type = char.ToLower(char.Parse(Console.ReadLine()));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double perHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employees.Add(new OutsourcedEmployee(name, hours, perHour, addCharge));                    
                }
                else
                {
                    Employees.Add(new Employee(name, hours, perHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
