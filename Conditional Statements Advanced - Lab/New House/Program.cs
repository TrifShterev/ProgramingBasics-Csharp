using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double numFlowers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0.0;
            
            bool flower = type == "Roses" || type == "Dahlias" || type== "Tulips"||type== "Narcissus"||type== "Gladiolus";

            if (flower)
            {
                if (type == "Roses" && numFlowers > 80)
                {
                    price = 5 * 0.9;

                }
                else if (type == "Roses")
                {
                    price = 5;
                }

                else if (type == "Dahlias")
                {
                    if (type == "Dahlias" && numFlowers > 90)
                    {
                        price = 3.80 * 0.85;
                    }
                    else if (type == "Dahlias")
                    {
                        price = 3.80;
                    }
                }
                else if (type == "Tulips")
                {
                    if (type == "Tulips" && numFlowers > 80)
                    {
                        price = 2.80 * 0.85;

                    }
                    else if (type == "Tulips")
                    {
                        price = 2.80;
                    }
                }
                else if (type == "Narcissus")
                {
                    if (type == "Narcissus" && numFlowers < 120)
                    {
                        price = 3 + (3 * 0.15);
                    }
                    else if (type == "Narcissus")
                    {
                        price = 3;
                    }
                }
                else if (type == "Gladiolus")
                {
                    if (type == "Gladiolus" && numFlowers < 80)
                    {
                        price = 2.5 + (2.5 * 0.2);
                    }
                    else if (type == "Gladiolus")
                    {
                        price = 2.5;
                    }
                }
            }
            double totalFlowersPrice = numFlowers * price;

            if (totalFlowersPrice<=budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {type} and {budget-totalFlowersPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalFlowersPrice-budget:F2} leva more.");
            }
            
        }
    }
}
