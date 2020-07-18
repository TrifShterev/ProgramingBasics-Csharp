using System;
class Program
{
    static void Main(string[] args)
    {
        string destination = Console.ReadLine();
        while (destination != "End")
        {
            double sum = 0;
            double buget = double.Parse(Console.ReadLine());
            while (sum < buget)
            {
                double instalment = double.Parse(Console.ReadLine());
                sum += instalment;
            }
            Console.WriteLine($"Going to {destination}!");
            destination = Console.ReadLine();
        }
    }
}