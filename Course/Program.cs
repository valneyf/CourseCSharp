using System;
using System.Collections.Generic;
using System.IO;
using Course.Entities;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, int> election = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(",");

                        if (!election.ContainsKey(line[0])) {
                            election.Add(line[0], int.Parse(line[1]));
                        }
                        else {
                            election[line[0]] += int.Parse(line[1]);
                        }
                    }
                }

                Console.WriteLine("Result elections: ");
                foreach (var candidate in election) {
                    Console.WriteLine(candidate.Key + ": " + candidate.Value);
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

