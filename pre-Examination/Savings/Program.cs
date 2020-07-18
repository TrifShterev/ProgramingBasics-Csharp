using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double pExpences = double.Parse(Console.ReadLine());

            double inpredictbleSituations = income * 0.3;
            double expences = pExpences + inpredictbleSituations;
            double savings = income - expences;
            double totalSavings = months * savings;

            double percentage = savings/ income*100;

            Console.WriteLine($"She can save {percentage:F2}%");
            Console.WriteLine($"{totalSavings:F2}");

        }
    }
}
