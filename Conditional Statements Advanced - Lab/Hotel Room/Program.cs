using System;
using System.Diagnostics.CodeAnalysis;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            bool spring = month == "May"|| month=="Oktober";
            bool midSummer = month == "June" || month == "September";
            bool summer = month == "July" || month == "August";
            double priceApartment = 0;
            double priceStudio = 0;

            

            if (spring)
            {
                
                if (nights>7&&nights<14)
                {  priceApartment = 65*nights;
                    priceStudio =(50*0.95)*nights;
                    

                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
                else if (nights>=14)
                {
                    priceApartment = (65*0.90)*nights;
                    priceStudio =(50*0.70)*nights;

                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");

                }
                else
                {
                    priceApartment = 65*nights;
                    priceStudio =50*nights;

                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
            }
            else if (midSummer)
            {
                if (nights>14)
                {
                    priceApartment = (68.70*0.9)*nights;
                    priceStudio =(75.20*0.8)*nights;

                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
                else
                {
                    priceApartment = 68.70*nights;
                    priceStudio =75.20*nights;

                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
            }
            else if (summer)
            {
                if (nights>14)
                {
                    priceApartment = (77*0.9)*nights;
                    priceStudio =76*nights;

                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
                else
                {
                    priceApartment = 77*nights;
                    priceStudio =76*nights;

                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
               
            }
        }
    }
}
