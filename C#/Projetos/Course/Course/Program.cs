using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte n = 127; 
            Byte n1 = 255; 
            Boolean bol = true;
            char l = 'F';
            char letra = '\u0246';
            int n2 = int.MinValue;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria";
            Object ob1 = "Alo alo";
            Object ob2 = 6.9;

            n++;
            n1++;
            n2--;

            Console.WriteLine(n);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(ob1);
            Console.WriteLine(ob2);

        }
    }
}
