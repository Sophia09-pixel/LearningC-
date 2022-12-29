using System;
using System.Globalization;

namespace Corporation
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Digite a Data de hoje");
            int Data = int.Parse(Console.ReadLine());

            Console.WriteLine($"Vamos Calcular o faturamento de hoje: {Data}");

            Console.WriteLine("Digite o Valor passado na REDE:");
            double CieloBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor passado na PAGSEGURO:");
            double PagSegBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Se houve pagamento em dinheiro digite: (se não digite 0)");
            double Dinheiro = double.Parse(Console.ReadLine());

            Console.WriteLine("Se houve pagamento em PIX digite: (se não digite 0)");
            double PIX = double.Parse(Console.ReadLine());

            double Bruto = CieloBruto + PagSegBruto + PIX + Dinheiro;

            Console.WriteLine($"O Bruto de Hoje foi: R$ {Bruto.ToString("F2", CultureInfo.InvariantCulture)}");


            Console.WriteLine("Agora iremos Calcular o Liquido:");

            Console.WriteLine("Digite o Valor de Crédito passado na REDE:");
            double CieloCreditLiquido = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor de Débito passado na REDE:");
            double CieloDebitLiquido = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor de Crédito passado na PagSeguro:");
            double PagCreditLiquido = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor de Débito passado na PagSeguro:");
            double PagDebitLiquido = double.Parse(Console.ReadLine());

            double CieloCreditTaxa = CieloCreditLiquido * 0.0359;
            double CieloDebitTaxa = CieloDebitLiquido * 0.0119;

            double PagCreditTaxa = PagCreditLiquido * 0.0449;
            double PagDebitTaxa = PagDebitLiquido * 0.0199;

            double CieloCreditFinal = CieloCreditLiquido - CieloCreditTaxa;
            double CieloDebitFinal = CieloDebitLiquido - CieloDebitTaxa;

            double PagCreditFinal = PagCreditLiquido - PagCreditTaxa;
            double PagDebitFinal = PagDebitLiquido - PagDebitTaxa;

            double Liquidorede = CieloCreditFinal + CieloDebitFinal;
            Console.WriteLine($"O valor liquido da rede foi de: R$ {Liquidorede.ToString("F2", CultureInfo.InvariantCulture)}");


            double Liquido = CieloCreditFinal + CieloDebitFinal + PagCreditFinal + PagDebitFinal + PIX + Dinheiro;
            Console.WriteLine($"O Liquido de Hoje foi: R$ {Liquido.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("===========================");

            Console.WriteLine("Digite se seu dia foi legal de 0 a 10");
            int dia1 = int.Parse(Console.ReadLine());

            if (dia1 <= 5 )
            {
                Console.WriteLine("Continue firme e forte");
            }else
                Console.WriteLine("VAI DAR TUDO CERTO :D");
          

            if (Data != 15)
            {
                Console.WriteLine("Tenha um ótimo mês :)");
           
            }

            if (Data == 15)
            {
                Console.WriteLine("---- Fechamento da Primeira Quinzena ----");

                Console.WriteLine("Digite o total de Adriana na quinzena:");
                double adriana = double.Parse(Console.ReadLine());

                double TotalDi = adriana * 0.6;

                Console.WriteLine($"O Total de Adriana foi: R$ {TotalDi.ToString("F2", CultureInfo.InvariantCulture)}");

                double lucroDi = adriana * 0.4;

                Console.WriteLine($"Seu Lucro foi de: {lucroDi.ToString("F2", CultureInfo.InvariantCulture)}");

                Console.WriteLine("Digite a CAIXINHA de Adriana");
                double cx = double.Parse(Console.ReadLine());
                double totcx = cx * 0.08;
                double totalcaxdi = cx - totcx;
                Console.WriteLine($"O total de caixinha foi de{totalcaxdi.ToString("F2", CultureInfo.InvariantCulture)}");

                double totaldi = totalcaxdi + TotalDi;
                Console.WriteLine($"Logo o TOTAL DA QUINZENA DE ADRIANA FOI DE: R$ {totaldi.ToString("F2", CultureInfo.InvariantCulture)}");


                Console.WriteLine("_______________________________________");

                Console.WriteLine("Digite o total de Arlete na quinzena:");
                double arlete = double.Parse(Console.ReadLine());

                double TotalArlete = arlete * 0.6;

                Console.WriteLine($"O Total de Arlete foi: R$ {TotalArlete.ToString("F2", CultureInfo.InvariantCulture)}");

                double lucroArle = arlete * 0.4;

                Console.WriteLine($"Seu Lucro foi de: {lucroArle.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Digite a CAIXINHA de ARLETE");
                double cxar = double.Parse(Console.ReadLine());
                double totcxar = cxar * 0.08;
                double totalcaxar = cxar - totcxar;
                Console.WriteLine($"O total de caixinha foi de{totalcaxar.ToString("F2", CultureInfo.InvariantCulture)}");

                double totalar = totalcaxar + TotalArlete;
                Console.WriteLine($"Logo o TOTAL DA QUINZENA DE ARLETE FOI DE: R$ {totalar.ToString("F2", CultureInfo.InvariantCulture)}");


                Console.WriteLine("_______________________________________");


                Console.WriteLine("Digite o total de Jessica  na quinzena:");
                double jessica = double.Parse(Console.ReadLine());

                double TotalJessica = jessica * 0.6;

                Console.WriteLine($"O Total de Jessica foi: R$ {TotalJessica.ToString("F2", CultureInfo.InvariantCulture)}");

                double lucroJess = jessica * 0.4;


                Console.WriteLine("Digite a CAIXINHA de JESSICA");
                double cxje = double.Parse(Console.ReadLine());
                double totcxje = cxje * 0.08;
                double totalcaxjes = cxje - totcxje;
                Console.WriteLine($"O total de caixinha foi de: {totalcaxjes.ToString("F2", CultureInfo.InvariantCulture)}");

                double totalje = totalcaxjes + TotalJessica;
                Console.WriteLine($"Logo o TOTAL DA QUINZENA DE JESSICA FOI DE: R$ {totalje.ToString("F2", CultureInfo.InvariantCulture)}");


                Console.WriteLine("_______________________________________");



                Console.WriteLine($"Seu Lucro foi de: {lucroJess.ToString("F2", CultureInfo.InvariantCulture)}");

                double totalLucro = lucroDi + lucroArle + lucroJess;

                Console.WriteLine($"Seu lucro de comições foi de:{totalLucro.ToString("F2", CultureInfo.InvariantCulture)} ");

                
            }



            Console.WriteLine("===========================");

            if (Data >= 30)
            {
                Console.WriteLine("Digite o total de Adriana na quinzena:");
                double adriana = double.Parse(Console.ReadLine());

                double TotalDi = adriana * 0.6;

                Console.WriteLine($"O Total de Adriana foi: R$ {TotalDi.ToString("F2", CultureInfo.InvariantCulture)}");

                double lucroDi = adriana * 0.4;

                Console.WriteLine($"Seu Lucro foi de: {lucroDi.ToString("F2", CultureInfo.InvariantCulture)}");

                Console.WriteLine("Digite o total de Arlete na quinzena:");
                double arlete = double.Parse(Console.ReadLine());

                double TotalArlete = arlete * 0.6;

                Console.WriteLine($"O Total de Arlete foi: R$ {TotalArlete.ToString("F2", CultureInfo.InvariantCulture)}");

                double lucroArle = arlete * 0.4;

                Console.WriteLine($"Seu Lucro foi de: {lucroArle.ToString("F2", CultureInfo.InvariantCulture)}");

                Console.WriteLine("Digite o total de Jessica  na quinzena:");
                double jessica = double.Parse(Console.ReadLine());

                double TotalJessica = jessica * 0.6;

                Console.WriteLine($"O Total de Jessica foi: R$ {TotalJessica.ToString("F2", CultureInfo.InvariantCulture)}");

                double lucroJess = jessica * 0.4;


                Console.WriteLine($"Seu Lucro foi de: {lucroJess.ToString("F2", CultureInfo.InvariantCulture)}");

                double totalLucro = lucroDi + lucroArle + lucroJess;

                Console.WriteLine($"Seu lucro de comições foi de:{totalLucro.ToString("F2", CultureInfo.InvariantCulture)} ");
            }
           


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
            Console.WriteLine("--dasdasasdasd--------------------------------");

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


                Console.WriteLine("Digite um número");


                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número positivo");
                int k = int.Parse(Console.ReadLine());
                if (k <= 10)
                {
                    Console.WriteLine(" Tanto numero pra pensar e foi pensar nesse??");
                }

     

            }
        }
    }
}      
    
