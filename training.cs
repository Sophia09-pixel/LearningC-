using System;
using System.Globalization;

namespace Corporation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---1---");

            Console.WriteLine("Digite um número:");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double Raiz = Math.Sqrt(x);
                Console.WriteLine(Raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número Negativo!");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Exercicio 1:");

            Console.WriteLine("Digite a Senha:");
            int Senha = int.Parse(Console.ReadLine());

            while (Senha != 2002)
            {
                Console.Write("Senha Inválida!");
                Console.WriteLine("Tente Novamente: ");

                Senha = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acesso Permitido:");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Exercicio 2:");

            Console.WriteLine("Digite Dois Números");

            string[] valores = Console.ReadLine().Split(' ');
            int X = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (X != 0 && y != 0)
            {
                if (X > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (X < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (X < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }


                valores = Console.ReadLine().Split(' ');
                X = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
                Console.WriteLine("----------------------------------");

                Console.WriteLine("Exercicio 3");

                int Alcool = 0;
                int Gasolina = 0;
                int Diesel = 0;

                Console.WriteLine("Digite qual a sua preferencia para abastecimento:");

                int tipo = int.Parse(Console.ReadLine());

                while (tipo != 4)
                {
                    if (tipo == 1)
                    {
                        Alcool = Alcool + 1;
                    }else if (tipo == 2)
                    {
                        Gasolina = Gasolina + 1;

                    }else if (tipo == 3) 
                    {
                        Diesel = Diesel + 1;

                    }

                    tipo = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("MUITO OBRIGADO:");
                Console.WriteLine($"Alcool: {Alcool}");
                Console.WriteLine($"Gasolina: {Gasolina}");
                Console.WriteLine($"Diesel: {Diesel}");
                
   

            }
        }
    }
}      
    
    
