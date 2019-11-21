using System;
using System.Globalization;

namespace Exercicio02Aula40
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario a, b;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            a.NOME = Console.ReadLine();
            Console.Write("Sálario: ");
            a.SALARIO = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            b.NOME = Console.ReadLine();
            Console.Write("Sálario: ");
            b.SALARIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (a.SALARIO + b.SALARIO) / 2;

            Console.WriteLine("Sálario médio = " + mediaSalario.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
