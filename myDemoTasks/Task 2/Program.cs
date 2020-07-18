using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int task = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            double coef = 0;
            if (name=="Basics")
            {
                switch (task)
                {
                    case 1:
                        coef = (points * 0.08)*0.8;
                        break;
                    case 2:
                        coef = (points * 0.09)*0.8;
                        break;
                    case 3:
                        coef = (points * 0.09)*0.8;
                        break;
                    case 4:
                        coef = (points * 0.1)*0.8;
                        break;
                }

            }
            else if (name=="Fundamentals")
            {
                switch (task)
                {
                    case 1:
                        coef = points * 0.11;
                        break;
                    case 2:
                        coef = points * 0.11;
                        break;
                    case 3:
                        coef = points * 0.12;
                        break;
                    case 4:
                        coef = points * 0.13;
                        break;
                }
            }
            else if (name=="Advanced")
            {
                switch (task)
                {
                    case 1:
                        coef = (points * 0.14) * 1.2;
                        break;
                    case 2:
                        coef = (points * 0.14) * 1.2;
                        break;
                    case 3:
                        coef = (points * 0.15) * 1.2;
                        break;
                    case 4:
                        coef = (points * 0.16) * 1.2;
                        break;
                }
            }
            Console.WriteLine($"Total points: {coef:f2}");

        }
        
       
    }
}
