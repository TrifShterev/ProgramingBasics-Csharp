using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double lenght = L * 100;
            double width = W * 100;
            double arc = A * 100;
            // Calculations for the Area
            double hallArea = lenght * width;
            double arcArea = arc * arc;
            double benchArea = hallArea / 10;
            double dancerArea = 7000 + 40;
            // Calculations
            double hallFreeSpace = hallArea - Math.Round(arcArea + benchArea);
            double dancers = hallFreeSpace / dancerArea;

            //Result

            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
