using System;

namespace ExerciciosSequenciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            Console.WriteLine("Digite o primeiro valor:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            int n2 = int.Parse(Console.ReadLine());
            int adicao = soma(n1, n2);

            Console.WriteLine(adicao);

            //Exercicio 2
        }

        static int soma(int n1,int n2)
        {
            return n1 + n2;
        }
    }
}
