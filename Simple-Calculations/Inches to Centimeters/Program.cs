using System;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = 2.54;
                double result = a * b;
            Console.WriteLine(result);
        }
    }
}
