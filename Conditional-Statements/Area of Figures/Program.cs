using System;
using System.Drawing;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string fig = Console.ReadLine();

            if (fig == "square")
            {
                double num = double.Parse(Console.ReadLine());
                double sArea = num * num;
                Console.WriteLine($"{sArea:F3}");

            }
            else if (fig == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double rArea = a * b;
                Console.WriteLine($"{rArea:F3}");

            }
            else if (fig == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double cArea = Math.PI * (r * r);

                Console.WriteLine($"{cArea:F3}");
            }
            else if (fig == "triangle") { 
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double tArea = (a * h) / 2;

                Console.WriteLine($"{tArea:F3}");
            }
            
        }
    }
}
