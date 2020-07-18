using System;

namespace Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruise = Console.ReadLine();
            string cabin = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double costOfTheTrip = 0;
            if (nights > 7)
            {


                if (cruise == "Mediterranean")
                {
                    if (cabin == "standard cabin")
                    {
                        costOfTheTrip = (nights * 27.50) * 0.75;
                    }
                    else if (cabin == "cabin with balcony")
                    {
                        costOfTheTrip = (nights * 30.20) * 0.75;
                    }
                    else if (cabin == "apartment")
                    {
                        costOfTheTrip = (nights * 40.50) * 0.75;
                    }
                }
                else if (cruise == "Adriatic")
                {
                    if (cabin == "standard cabin")
                    {
                        costOfTheTrip = (nights * 22.99) * 0.75;
                    }
                    else if (cabin == "cabin with balcony")
                    {
                        costOfTheTrip = (nights * 25) * 0.75;
                    }
                    else if (cabin == "apartment")
                    {
                        costOfTheTrip = (nights * 34.99) * 0.75;
                    }
                }
                else if (cruise == "Aegean")
                {
                    if (cabin == "standard cabin")
                    {
                        costOfTheTrip = (nights * 23.00) * 0.75;
                    }
                    else if (cabin == "cabin with balcony")
                    {
                        costOfTheTrip = (nights * 26.60) * 0.75;
                    }
                    else if (cabin == "apartment")
                    {
                        costOfTheTrip = (nights * 39.80) * 0.75;
                    }
                }
            }
            else if (nights <= 7)
            {


                if (cruise == "Mediterranean")
                {
                    if (cabin == "standard cabin")
                    {
                        costOfTheTrip = nights * 27.50;
                    }
                    else if (cabin == "cabin with balcony")
                    {
                        costOfTheTrip = nights * 30.20;
                    }
                    else if (cabin == "apartment")
                    {
                        costOfTheTrip = nights * 40.50;
                    }
                }
                else if (cruise == "Adriatic")
                {
                    if (cabin == "standard cabin")
                    {
                        costOfTheTrip = nights * 22.99;
                    }
                    else if (cabin == "cabin with balcony")
                    {
                        costOfTheTrip = nights * 25;
                    }
                    else if (cabin == "apartment")
                    {
                        costOfTheTrip = (nights * 34.99);
                    }
                }
                else if (cruise == "Aegean")
                {
                    if (cabin == "standard cabin")
                    {
                        costOfTheTrip = (nights * 23.00);
                    }
                    else if (cabin == "cabin with balcony")
                    {
                        costOfTheTrip = (nights * 26.60);
                    }
                    else if (cabin == "apartment")
                    {
                        costOfTheTrip = (nights * 39.80);
                    }
                }
            }
            Console.WriteLine($"Annie's holiday in the {cruise} sea costs {(costOfTheTrip*4):F2} lv.");
        }
    }
    }

