using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            string text2 = Console.ReadLine();
            
            
            if (text == "m" && text2 == "cm")

            {
                double cm = num * 100;
                
                Console.WriteLine($"{cm:F3}");
            }
            else if (text == "cm" && text2 == "mm")
            {
                double mm = num * 10;
                Console.WriteLine($"{mm:F3}");
            }
            else if (text == "mm" && text2 == "m")
            {
                double m = num / 1000;
                Console.WriteLine($"{m:F3}");
            
        } else if (text =="cm" && text2 == "m")
            {
                double m = num / 100;
                Console.WriteLine($"{m:F3}");
            }
            else if(text == "m"  && text2 == "mm") {
                double mm = num * 1000;
                Console.WriteLine($"{mm:F3}");
            }
        }
    }
}
