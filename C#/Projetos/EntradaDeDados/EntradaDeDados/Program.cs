using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um Produto");
            double pProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura(mesma linha)");
            string s = Console.ReadLine();
            string[] v = s.Split(' ');
            string ultimoNome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2],CultureInfo.InvariantCulture);

            Console.WriteLine("Você decidou:");
            Console.WriteLine("Nome Completo:" + nome);
            Console.WriteLine("Quantidades de quartos:" + qtdQuartos);
            Console.WriteLine("Preço do produto:" + pProduto.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Ultimo nome:" + ultimoNome);
            Console.WriteLine("Idade:" + idade);
            Console.WriteLine("Altura:" + altura);
            

        }
    }
}
