using System;
using System.Diagnostics.Tracing;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            int counter = 1;
            int klas = 1;
            
            while (klas <= 12)
            {

                double evaluation = double.Parse(Console.ReadLine());
                sum += evaluation;
                klas++;
                
                if (evaluation<4)
                {
                    klas--;
                    
                    if (klas<counter)
                    {
                        Console.WriteLine($"{name} has been excluded at {klas} grade ");
                        return;
                    }
                    
                
                }counter++;
            }
            Console.WriteLine($"{name} graduated. Average grade: {sum/12:F2}");


        }
    }
}
