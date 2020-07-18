using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double places = r * c;
            double income = 0.0;
            switch (type)
            {
                case "Premiere":
                    income = places * 12.00;
                    Console.WriteLine($"{income:F2} leva");

                    break;
                case "Normal":
                    income = places * 7.50;
                    Console.WriteLine($"{income:F2} leva");


                    break;
                case "Discount":
                    income = places * 5.00;
                    Console.WriteLine($"{income:F2} leva");
                    break;
            }
        }
    }
}
