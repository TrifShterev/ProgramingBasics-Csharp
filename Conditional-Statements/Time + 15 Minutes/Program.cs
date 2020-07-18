using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            if (seconds <= 44 && hours <= 22)
            {
                int secondsAfter15 = seconds + 15;
                Console.WriteLine($"{hours}:{secondsAfter15}");
            }

            else if (seconds > 44 && hours <= 22)
            {
                double secondsAfter15 = (seconds + 15) % 60;
                if (secondsAfter15 < 10)
                {
                    Console.WriteLine($"{hours + 1}:0{secondsAfter15}");
                }
                else if (secondsAfter15 >= 10)
                {
                    Console.WriteLine($"{hours + 1}:{secondsAfter15}");
                }
            }

            else if (seconds > 44 && hours == 23)
            {
                double secondsAfter15 = (seconds + 15) % 60;
                if (secondsAfter15 < 10)
                {
                    Console.WriteLine($"0:0{secondsAfter15}");
                }
                else if (secondsAfter15 >= 10)
                {
                    Console.WriteLine($"0:{secondsAfter15}");
                }
            }
            else if (seconds <= 44 && hours == 23)
            {
                double secondsAfter15 = (seconds + 15) % 60;
                if (secondsAfter15 < 10)
                {
                    Console.WriteLine($"23:0{secondsAfter15}");
                }
                else if (secondsAfter15 >= 10)
                {
                    Console.WriteLine($"23:{secondsAfter15}");
                }



            }
        }
    }
}