using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of lines and columns of matrix: ");
            string[] numbers = Console.ReadLine().Split(" ");

            int m = int.Parse(numbers[0]);
            int n = int.Parse(numbers[1]);

            int[,] mat = new int[m, n];

            //List<int> list = new List<int>();

            for (int i = 0; i < m; i++) {
                Console.WriteLine($"Enter the values #{i + 1} line of matrix:");
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Enter the wish number of the matrix:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine($"Position {i},{j}:");

                        // Left
                        if (j > 0 && j <= n) {
                            Console.Write("Left: " + mat[i, j - 1]);
                            Console.WriteLine();
                        }

                        // Right
                        if (j >= 0 && j < n - 1) {
                            Console.Write("Right: " + mat[i, j + 1]);
                            Console.WriteLine();
                        }

                        // Up
                        if (i > 0 && i <= m) {
                            Console.Write("Up: " + mat[i - 1, j]);
                            Console.WriteLine();
                        }

                        // Down
                        if (i >= 0 && i < m - 1) {
                            Console.Write("Down: " + mat[i + 1, j]);
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
