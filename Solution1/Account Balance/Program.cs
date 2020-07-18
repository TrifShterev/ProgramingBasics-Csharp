using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double counter = 0;
            double total = 0;
            while (counter<n)
            {
                double amount = double.Parse(Console.ReadLine());
                         
               
                if (amount<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {amount:F2}");
                total += amount;
                counter++;

            }
            Console.WriteLine($"Total: {total:F2}");

        }
    }
}
