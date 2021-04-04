using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Course.Entities;


namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double inputSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            var emails = list.Where(p => p.Salary > inputSalary).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine("Email of people whose salary is more than " + inputSalary.ToString("F2", CultureInfo.InvariantCulture));
            foreach (string email in emails) {
                Console.WriteLine(email);
            }

            var salariesM = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.Write("Sum of salary of people whose name starts with 'M': " + salariesM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

