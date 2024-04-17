using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, n, F1, F2, proximo;

            F1 = 0;
            F2 = 1;
            i = 0;
            proximo = 0;

            Console.WriteLine("Digite o número limite para a sequência de Fibonacci que deseja imprimir: ");
            n = int.Parse(Console.ReadLine());

            while (proximo < n)
            {
                proximo = F1 + F2;

                if (proximo < n)
                    Console.Write($"{proximo}");

                F1 = F2;
                F2 = proximo;
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
