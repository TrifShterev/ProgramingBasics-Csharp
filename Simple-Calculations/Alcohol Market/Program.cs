using System;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double wPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            //Alcohol Prices
            double rakiaPrice = wPrice / 2;
            double beerPrice = rakiaPrice * (1 - 0.8);
            double winePrice = rakiaPrice * (1 - 0.4);
            double whiskeyPrice = rakiaPrice*2;

            // Alcohol quantity
            double beerSum = beer * beerPrice;
            double wineSum = wine * winePrice;
            double rakiaSum = rakia * rakiaPrice;
            double whiskeySum = whiskey * whiskeyPrice;

            //Peshoe need´s:
            double total = beerSum + wineSum + rakiaSum + whiskeySum;

            Console.WriteLine($"{total:F2}");
        }
    }
}
