using System;

namespace Desy_s_cat
{
    class Program
    {
        static void Main(string[] args)
        {
            double minWalkPerDay = double.Parse(Console.ReadLine());
            double walksPerDay = double.Parse(Console.ReadLine());
            double cal = double.Parse(Console.ReadLine());

            double timeOfWalk = minWalkPerDay * walksPerDay;
            double totalBurnedCal = timeOfWalk * 5;
            double target = cal / 2;

            Console.WriteLine(totalBurnedCal >= target ?
                $"Yes, the walk for your cat is enough. Burned calories per day:{totalBurnedCal}":
                $"No, the walk for your cat is not enough. Burned calories per day: {totalBurnedCal}");
        }
    }
}
