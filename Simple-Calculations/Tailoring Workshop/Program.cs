using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tables = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double tclothArea = tables * (lenght + 2 * 0.30) * (width + 2 * 0.30);
            double tSquare = tables * (lenght / 2 * lenght / 2);

            double priceTcloth = tclothArea * 7;
            double priceTsquare = tSquare * 9;
            double USD = priceTcloth + priceTsquare;
            double BGN = 1.85 * (priceTcloth + priceTsquare);

            Console.WriteLine($"{USD:F2} USD");
            Console.WriteLine($"{BGN:F2} BGN");
        }
    }
}
