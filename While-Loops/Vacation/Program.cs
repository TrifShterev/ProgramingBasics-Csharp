using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double VacationCost = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            
            double spentMoneyCounter = 0;
            int dayCounter = 0;

            while (money<VacationCost&&spentMoneyCounter<5)
            {
                string action = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());
                if (action=="save")
                {
                    money += currentMoney;
                }
                else if (action=="spend")
                {
                    if (currentMoney>money)
                    {
                        money = 0;
                        spentMoneyCounter++;
                    }
                    else
                    {
                        spentMoneyCounter++;
                        money -= currentMoney;
                    }
                    
                }
                dayCounter++;
            }
            if (money>=VacationCost)
            {
                Console.WriteLine($"You saved the money for {dayCounter} days."
);
            }
            else if (spentMoneyCounter == 5 )
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(dayCounter);
            }
        }
    }
}
