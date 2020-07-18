using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fisherMans = double.Parse(Console.ReadLine());


            double price = 0.00;



            if (season == "Spring")
            {
                if (fisherMans <= 6)
                {
                    price = 3000 * 0.9;
                }
                else if (fisherMans >= 7 && fisherMans <= 11)
                {
                    price = 3000 * 0.85;
                }
                else if (fisherMans >= 12)
                {
                    price = 3000 * 0.75;
                }
            }

            else if (season == "Summer")
            {
                if (fisherMans <= 6)
                {
                    price = 4200 * 0.90;
                }
                else if (fisherMans >= 7 && fisherMans <= 11)
                {
                    price = 4200 * 0.85;
                }
                else if (fisherMans >= 12)
                {
                    price = 4200 * 0.75;
                }
            }
            else if (season == "Autumn")
            {
                if (fisherMans <= 6)
                {
                    price = 4200 * 0.9;
                }
                else if (fisherMans >= 7 && fisherMans <= 11)
                {
                    price = 4200 * 0.85;
                }
                else if (fisherMans >= 12)
                {
                    price = 4200 * 0.75;
                }
            }

            else if (season == "Winter")
            {
                if (fisherMans <= 6)
                {
                    price = 2600 * 0.90;
                }
                else if (fisherMans >= 7 && fisherMans <= 11)
                {
                    price = 2600 * 0.85;
                }
                else if (fisherMans >= 12)
                {
                    price = 2600 * 0.75;
                }
            }




            if (budget - price >= 0)
            {
                if (fisherMans % 2 == 0)
                {

                    Console.WriteLine($"Yes! You have {budget - price * 0.95:F2} leva left.");
                }
                else if (fisherMans % 2 == 0 && season == "Autumn")
                {
                    Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
                }
                else { Console.WriteLine($"Yes! You have {budget - price:F2} leva left."); }
            }

            else if (price - budget < 0)
            {
                Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
            }




        }
    }
}








