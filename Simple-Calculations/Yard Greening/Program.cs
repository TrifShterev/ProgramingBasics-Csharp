using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardMeters = double.Parse(Console.ReadLine());
            double price = 7.61;
            
            double wholePrice = yardMeters * price;
            double discount = wholePrice * 0.18;
            Console.WriteLine($"The final price is: {wholePrice-discount :F2} lv.");

            Console.WriteLine($" The discount is: {discount:F2} lv. ");
        }
    }
}
