namespace study.cont
{
    class Program
    {
        static void Main(string[] args)
          
        {
          
            Console.WriteLine("Entre com o angulo x:");
              double Xa, Xb, Xc, Ya, Yb, Yc;
            Xa = double.Parse(Console.ReadLine());
            Xb = double.Parse(Console.ReadLine());
            Xc = double.Parse(Console.ReadLine());


            Console.WriteLine("Entre com o angulo y:");
           
            Ya = double.Parse(Console.ReadLine());
            Yb = double.Parse(Console.ReadLine());
            Yc = double.Parse(Console.ReadLine());

            double p = (Xa + Xb + Xc) / 2;
            double areaX = Math.Sqrt(p * (p - Xa) * (p - Xb) * (p - Xc));

            p = (Ya + Yb + Yc) / 2;
            double areaY = Math.Sqrt(p * (p - Ya) * (p - Yb) * (p - Yc));

            Console.WriteLine($"Area de X = {areaX.ToString("F4",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y = {areaY.ToString("F4",CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X ");
            }else
                Console.WriteLine("Maior area: Y");



        }
    }
}
