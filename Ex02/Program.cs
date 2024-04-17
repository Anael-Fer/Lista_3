using System;


namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalD, somaV, valorM, valor, quantDias;
            double media;

            quantDias = 1;
            totalD = 0;
            somaV = 0;
            valorM = 0;
            valor = 0;

            while (quantDias <= 5) 
            {

                Console.WriteLine("Informe um valor");
                valor = int.Parse(Console.ReadLine());

                somaV += valor;

                if(valor > valorM)
                {
                    valorM = valor;
                    
                }
                quantDias++;
            }

            media = somaV / quantDias;
            totalD = quantDias;

            Console.WriteLine("Média: " +  media);
            Console.WriteLine("Maior valor: " + valorM + "Dia máximo: " + totalD);

            Console.ReadLine();

           
        }
    }
}
