using System;
using System.Collections.Generic;
using System.IO;
using Course.Entities;

namespace Course {
    class Program {
        static void Main(string[] args) {
            SortedSet<int> courseAlex = new SortedSet<int>();            

            Console.Write("How many students for course A? ");
            int studentsA = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsA; i++) {
                courseAlex.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            int studentsB = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsB; i++) {
                courseAlex.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            int studentsC = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsC; i++) {
                courseAlex.Add(int.Parse(Console.ReadLine()));
            }
               
            Console.WriteLine("Total students: " + courseAlex.Count);
        }
    }
}

