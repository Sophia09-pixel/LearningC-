using System;

namespace study5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int a = int.Parse(Console.ReadLine());
            
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            if (c1 = true){ // apenas teste
                Console.WriteLine("Legal");

            }
            else 
            {
                Console.WriteLine("Que pena");
            }

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("-------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

            Console.WriteLine("-------------------");

            bool c9 = 2 > 3 || 4 != 5; // true
            bool c10 = !(2 > 3) && 4 != 5; // true
            bool c11 = 10 < 5; // false
            bool c12 = c9 || c10 && c11; // true

            Console.WriteLine(c9);
            Console.WriteLine(c10);
            Console.WriteLine(c11);
            Console.WriteLine(c12);

            Console.WriteLine("-------------");

            int x = 10; //teste com memes :D
            if (x < 5)
            {
                Console.WriteLine("SE LIGA HEINNNNNNN");
            }
            else
            {
                Console.WriteLine(" É SOBRE ISSO  ");
            }

            Console.WriteLine("Entre com um numero inteiro:");
            int x1 = int.Parse(Console.ReadLine());

            if (x1 % 2 == 0 ){
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom Dia!");

            }else if ( hora >= 12 && hora < 18){
                Console.WriteLine("Boa Tarde");
            }else 
            {
                Console.WriteLine("Boa noite");

            }
            
            



        }
    }
}
