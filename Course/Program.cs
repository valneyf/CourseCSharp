using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa primPessoa, segPessoa;
            
            primPessoa = new Pessoa();
            segPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            primPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            segPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segPessoa.Idade = int.Parse(Console.ReadLine());

            if (primPessoa.Idade > segPessoa.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + primPessoa.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + segPessoa.Nome);
            }
        }
    }
}
