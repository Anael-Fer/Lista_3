
using System;

namespace Lista_03
{

    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i;          
            
            Console.WriteLine("Informe um número impar");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro número impar");
            y = int.Parse(Console.ReadLine());

            i = x;

            Console.WriteLine("A sequência de números são: ");

            while (i <= y)
            {
                  
                Console.WriteLine(i.ToString());
                i += 2;

            }

            Console.ReadLine();
        }
    }
}
