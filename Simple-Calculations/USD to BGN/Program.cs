using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549;
            double result = usd * bgn;
            Console.WriteLine("{0:F2}", result);
        }
    }
}
