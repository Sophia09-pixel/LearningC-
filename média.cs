using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nt1, nt2, nt3, nt4;
            int soma, media;


           

            // Mensagem de entrada;

            Console.WriteLine("Vamos calcular A media");
            Console.WriteLine(" ");

            // Coletar as notas para o calculo;

            Console.Write("Matematica: ");
            nt1 = int.Parse(Console.ReadLine());

            Console.Write("Português: ");
            nt2 = int.Parse(Console.ReadLine());

            Console.Write("Ciências: ");
            nt3 = int.Parse(Console.ReadLine());

            Console.Write("História: ");
            nt4 = int.Parse(Console.ReadLine());

           

            soma = (nt1 + nt2 + nt3 + nt4);
            media = soma / 4;

            Console.Write("soma =  " + soma);

            Console.Write("Media = " + media);

            Console.ReadKey();




        }
    }
}
