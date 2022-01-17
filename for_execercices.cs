using System;
using System.Globalization;
namespace Study._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros voce vai digitar?: ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0} ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;

            }
            Console.WriteLine($"Soma igual a: {soma}");

            Console.WriteLine("Exercicio 1");

            Console.Write("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Os Impares de 1 até {x} são:");

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
                Console.WriteLine("----------");

                Console.WriteLine("Exercicio 2");

                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                int count_in = 0;
                int count_out = 0;

                for (int j = 0; j < numero; j++)

                {
                    Console.WriteLine("Digite um número: ");
                    int y = int.Parse(Console.ReadLine());
                    if (x >= 10 || x <= 20)
                    {
                        count_in = count_in + 1;

                    }
                    else
                        count_out = count_out + 1;
                }
                Console.WriteLine($"O número {count_in} está entre 10 e 20");
                Console.WriteLine($"O número {count_out} não está entre 10 e 20");

                Console.WriteLine("Exercicio 3");
                int n = int.Parse(Console.ReadLine());

                for (int l = 0; l < n; l++)
                {

                    string[] line = Console.ReadLine().Split(' ');
                    int n1 = int.Parse(line[0]);
                    int n2 = int.Parse(line[1]);

                    if (n2 == 0)
                    {
                        Console.WriteLine("divisao impossivel");
                    }
                    else
                    {
                        double divisao = (double)n1 / n2;
                        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                    


                    }
                }
            }
        } 
    }
}

