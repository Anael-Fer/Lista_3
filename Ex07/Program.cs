using System;


namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, n, F1, F2, proximo;

            F1 = 0;
            F2 = 1;
            i = 0;

            Console.WriteLine("Digite o número de elementos da sequência de Fibonacci que deseja imprimir: ");
            n = int.Parse(Console.ReadLine());

            while (i < n)
            {
                proximo = F1 + F2;

                Console.WriteLine(proximo);

                F1 = F2;
                F2 = proximo;

                i++;
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
