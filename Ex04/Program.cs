using System;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x, y;

            Console.WriteLine("Escreva o valor de X");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de Y");
            y = double.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x >= 0 && y >= 0)
                    Console.WriteLine(x + y + ": primeiro quadrante");
                else if (x <= 0 && y >= 0)
                    Console.WriteLine(x + y + ": segundo quadrante");
                else if (x <= 0 && y <= 0)
                    Console.WriteLine(x + y + ": terceiro quadrante");
                else if (x >= 0 && y <= 0)
                    Console.WriteLine(x + y + ": quarto quadrante");

                Console.WriteLine("Escreva o valor de X");
                x = double.Parse(Console.ReadLine());

                Console.WriteLine("Escreva o valor de Y");
                y = double.Parse(Console.ReadLine());

            }

            Console.ReadLine();
        }
    }
}
