using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario primFunc, segFunc;
            double media;
            
            primFunc = new Funcionario();
            segFunc = new Funcionario();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            primFunc.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            primFunc.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            segFunc.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            segFunc.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (primFunc.Salario + segFunc.Salario) / 2.00;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
