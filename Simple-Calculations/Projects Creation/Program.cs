using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numPr = int.Parse(Console.ReadLine());
            int prHours = 3;
            int totalH = numPr * prHours;

            Console.WriteLine($" The architect {name} will need {totalH} hours to complete {numPr} project/s.");
        }
    }
}
