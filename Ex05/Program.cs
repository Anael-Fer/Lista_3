using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao, meses;
            double salario, novoSalario, valorFerias, decimo3;

            Console.WriteLine("Digite o número que condiz com a opção desejada: 1. Novo salário - 2. Férias - 3. Décimo terceiro - 4. Sair ");

            opcao = int.Parse(Console.ReadLine());

            while (opcao != 4)
            {

                if(opcao == 1)
                {
                    Console.WriteLine("Informe o valor do seu salário");
                    salario = double.Parse(Console.ReadLine());

                    if (salario <= 999.99)
                        novoSalario = salario * 1.15;
                    else if (salario >= 1000.00 && salario <= 2000.00)
                        novoSalario = salario * 1.10;
                    else
                        novoSalario = salario * 1.05;

                    Console.WriteLine("Seu novo salário é " + novoSalario);
                }
                else if(opcao == 2) 
                {
                    Console.WriteLine("Informe o valor do seu salário");
                    salario = double.Parse(Console.ReadLine());

                    valorFerias = salario + (salario / 3);

                    Console.WriteLine("O valor das suas férias é de " + valorFerias);

                }
                else if(opcao == 3)
                {
                    Console.WriteLine("Digite o número dos meses trabalhados (1 a 12)");
                    meses = int.Parse(Console.ReadLine());

                    if(meses <=0 && meses > 12)
                    {
                        Console.WriteLine("Informe o valor do seu salário");
                        salario = double.Parse(Console.ReadLine());

                        Console.WriteLine("Valor inválido. Digite um valor de meses válido");
                        meses = int.Parse(Console.ReadLine());
                    }
                    else if(meses >= 1 && meses <=12)
                    {
                        Console.WriteLine("Informe o valor do seu salário");
                        salario = double.Parse(Console.ReadLine());

                        decimo3 = salario * meses / 12;
                    }

                }
                Console.ReadLine();


            }
        }
    }
}
