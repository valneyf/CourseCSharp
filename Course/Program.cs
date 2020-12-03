using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the size of matrix: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            List<int> diagonal = new List<int>();

            int negativeNumbers = 0;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Enter the value of the matrix for position: ");
                    mat[i, j] = int.Parse(Console.ReadLine());

                    if (i == j) {
                        diagonal.Add(mat[i, j]);
                    }

                    if (mat[i, j] < 0) {
                        negativeNumbers++;
                    }
                }
            }

            Console.WriteLine("Main diagonal:");
            foreach (int obj in diagonal) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers = " + negativeNumbers);
        }
    }
}
