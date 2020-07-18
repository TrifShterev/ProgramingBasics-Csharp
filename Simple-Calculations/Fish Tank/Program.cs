using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double full = (a * b * c) * 0.001;
            double percentage = h * 0.01;



            Console.WriteLine( "{0:F3}", full * (1 - percentage));
        }
    }
}
