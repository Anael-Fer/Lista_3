using System;


namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int anos, totalAnos, cont, Pessoa5000, P15AnosEstudo;
            double salario, totalS, maiorS, mediaS, mediaEs, porcentS, porcentEs;
            char letra;

            anos = totalAnos = cont = 0;
            salario = totalS = 0;
            Pessoa5000 = P15AnosEstudo = 0;


            maiorS = double.MaxValue;

            Console.WriteLine("Digite 'S' para fazer a coleta de dados");
            letra = char.Parse(Console.ReadLine());

            while(letra == 'S')
            {

                cont++;

                Console.WriteLine("Informe o seu salário");
                salario = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe seus anos de estudos");
                anos = int.Parse(Console.ReadLine());

                totalS += salario;
                totalAnos += anos;

                if (salario > maiorS)
                    maiorS = salario;

                if (salario < 5000)
                    Pessoa5000++;

                if (anos >= 15)
                    P15AnosEstudo++;

                Console.WriteLine("Deseja informar os dados de outro habitante? Digite 'S' se desejar");
                letra = char.Parse(Console.ReadLine());

            }

            mediaS = totalS / cont;
            mediaEs = totalAnos / cont;

            porcentS = Pessoa5000 / cont * 100;
            porcentEs = P15AnosEstudo / cont * 100;

            Console.WriteLine("Média de salário da população: " + mediaS);
            Console.WriteLine("Média de anos por estudo da população: " + mediaEs);
            Console.WriteLine("Maior salário da população: " + maiorS);
            Console.WriteLine("Percentual de pessoas com salário até R$5000: " + porcentS);
            Console.WriteLine("Percentual de pessoas com 15 ou mais anos de estudo: " + porcentEs);

            Console.ReadLine();
        }
    }
}
