using System;

namespace Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double numOfToys = 0;
            double savedMoney = 0;
            double moneyFromBirthday = 10;

            for (int i = 1; i <= age; i++)
            { if (i % 2 == 0)
                {
                    savedMoney += (moneyFromBirthday - 1);
                       moneyFromBirthday += 10;
                }
                else { numOfToys++; }

            }
            savedMoney += toyPrice*numOfToys;
            Console.WriteLine(savedMoney >= machinePrice ?
                $"Yes! {(savedMoney-machinePrice):0.00}":
                $"No! {(machinePrice-savedMoney):0.00}");
        }
    }
}
