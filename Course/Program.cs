using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Console.Write("Nome do aluno: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a1.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a1.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + a1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
