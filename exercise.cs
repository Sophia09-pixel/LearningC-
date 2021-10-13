using System;
using System.Globalization; 

namespace Studying3
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2} cujo preço é $ {preco2:F2}");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero:{genero}");
            Console.WriteLine($"Medida com oito casas decimais:{medida:F8}");
            Console.WriteLine($"Arredondado {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture " + medida.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
