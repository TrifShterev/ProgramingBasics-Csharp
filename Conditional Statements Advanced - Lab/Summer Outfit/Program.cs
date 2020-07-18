using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();

            bool fresh = degrees >= 10 && degrees <= 18;
            bool cool = degrees > 18 && degrees <= 24;
            bool warm = degrees >= 25;
            string outfit = "";
            string shoes = "";

            if (partOfTheDay == "Morning")
            {
                if (fresh)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (cool)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (warm)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
            }
            else if (partOfTheDay == "Afternoon")
            {
                if (fresh)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (cool)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (warm)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
            }
            else if (partOfTheDay == "Evening")
            {
                if (fresh)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (cool)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (warm)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
            }

        }
    }
}
