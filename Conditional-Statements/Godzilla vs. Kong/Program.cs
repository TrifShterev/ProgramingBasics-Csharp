using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)

        {
            double buget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceForClothes = double.Parse(Console.ReadLine());

            double SumForClothes = statists * priceForClothes;
            double SumDecor = buget * 0.1;
            

            if (statists > 150)
            {
              SumForClothes -= SumForClothes * 0.1;

            }
            double expences = SumDecor + SumForClothes;
            double total = buget - expences;
            if (total >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {total:F2} leva left.");
                 }
            else if(total < 0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {expences-buget:F2} leva more.");
            }
        }
    }
}
