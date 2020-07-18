using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double cooks = double.Parse(Console.ReadLine());
            double cakes = double.Parse(Console.ReadLine());
            double waffles = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            // Sells
            double aDaySells = ((45 * cakes) + (5.80*waffles) + (3.20*pancakes))*cooks;
            double allSales = aDaySells * days;
            double total = allSales * (1 - 0.125);


            Console.WriteLine($"{total:F2}");
        }
    }
}
