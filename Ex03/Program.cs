using System;

namespace Ex03
{

    class Program
    {
        static void Main(string[] args)
        {
            int i, n, idade, cont1, cont2, cont3, cont4, cont5;
            double porcent1, porcent2, porcent3, porcent4, porcent5, totalP;
            
            cont1 = cont2 = cont3 = cont4 = cont5 = 0;
            i = 0;

            Console.WriteLine("Defina o número de pessoas");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {

                Console.WriteLine("Informe a idade");
                idade = int.Parse(Console.ReadLine());

                i++;

                if (idade >= 1 && idade <= 15)
                    cont1++;      
                    else if (idade >= 16 && idade <= 30)
                    cont2++;
                    else if (idade >= 31 && idade <= 45)
                    cont3++;
                    else if (idade >= 46 && idade <= 60)
                    cont4++;
                    else if (idade >= 61)
                    cont5++;
            }

            totalP = cont1 + cont2 + cont3 + cont4 + cont5;

            porcent1 = cont1 / totalP * 100;
            porcent2 = cont2 / totalP * 100;
            porcent3 = cont3 / totalP * 100;
            porcent4 = cont4 / totalP * 100;
            porcent5 = cont5 / totalP * 100;


            Console.WriteLine($"Quantidade de pessoas de [0-25]: {cont1}");
            Console.WriteLine($"Quantidade de pessoas de [26-50]: {cont2}");
            Console.WriteLine($"Quantidade de pessoas de [51-75]: {cont3}");
            Console.WriteLine($"Quantidade de pessoas de [76-100]: {cont4}");
            Console.WriteLine($"Quantidade de pessoas de [61 ou mais]: {cont5}");

            Console.WriteLine($"Porcentagem de pessoas de [0-25]: {porcent1}");
            Console.WriteLine($"Porcentagem de pessoas de [26-50]: {porcent2}");
            Console.WriteLine($"Porcentagem de pessoas de [51-75]: {porcent3}");
            Console.WriteLine($"Porcentagem de pessoas de [76-100]: {porcent4}");
            Console.WriteLine($"Porcentagem de pessoas de [61 ou mais]: {porcent5}");

            Console.ReadLine();
        }
    }
}