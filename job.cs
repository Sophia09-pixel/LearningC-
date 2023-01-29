using System;
using System.Globalization;

namespace Corporation
{
    class Program
    {
        static void Main(string[] args)

        {

            DateTime Data = DateTime.Now;
            Console.WriteLine($"Vamos Calcular o faturamento de hoje:");
            Console.WriteLine(Data.ToLongDateString());
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


            Console.WriteLine("Para fechamento de quinzena digite: 10");
            Console.WriteLine("Se não: < ou > 10");
            int quinzena = int.Parse(Console.ReadLine());


            if (quinzena == 10)
            {
                Console.WriteLine("---- Fechamento da Quinzena ----");

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
            else
            {
                Console.WriteLine("Bom fechamento :)");
            }

        }
    }


}    
    
