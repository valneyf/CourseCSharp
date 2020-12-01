using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int record = int.Parse(Console.ReadLine());

            for (int i = 1; i <= record; i++) {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());

            Employee busca = list.Find(x => x.Id == searchID);
            if (busca != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                busca.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
