using System;
using System.IO;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string sourcePath = @"d:\Projects\temp\myFolder\sales.csv";

            try {
                //Directory.CreateDirectory(Path.GetDirectoryName(sourcePath) + @"\out");
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(Directory.CreateDirectory(Path.GetDirectoryName(sourcePath) + @"\out") + @"\summary.csv")) {
                    
                    foreach (string line in lines) {
                        string[] dataProduct = line.Split(",");
                        double totalValue = double.Parse(dataProduct[1],CultureInfo.InvariantCulture) * double.Parse(dataProduct[2],CultureInfo.InvariantCulture);
                        sw.WriteLine(dataProduct[0] + "," + totalValue.ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }




        }
    }
}
