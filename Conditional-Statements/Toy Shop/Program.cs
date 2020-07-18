using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args) {
           

            double priceOfHolliday = double.Parse(Console.ReadLine());
            double numPuzzles = double.Parse(Console.ReadLine());
            double numDolls = double.Parse(Console.ReadLine());
            double numTeddies = double.Parse(Console.ReadLine());
            double numMinions = double.Parse(Console.ReadLine());
            double numTrucks = double.Parse(Console.ReadLine());

            //Prices
            double puzzle = 2.60;
            double doll = 3;
            double teddy = 4.10;
            double minion = 8.20;
            double truck = 2;

            double totalSales = numPuzzles * puzzle + numDolls * doll + numTeddies * teddy + numTrucks * truck + numMinions * minion;
            double totalOrders = numMinions + numDolls + numPuzzles + numTeddies + numTrucks;

            if (totalOrders >= 50)
            {
                totalSales -= totalSales * 0.25;
            }
            double rent = totalSales * 0.1;
            double profit = totalSales - rent;

            if (profit >= priceOfHolliday)
            {
                Console.WriteLine($"Yes! {profit-priceOfHolliday:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceOfHolliday-profit:F2} lv needed."
);
            }
        }
    }
}
