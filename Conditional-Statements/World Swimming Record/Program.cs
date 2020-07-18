using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
                    {
            double wRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeSecforM = double.Parse(Console.ReadLine());

            double resist = 15;
            double totalTime = distance * timeSecforM;
            double totalResist = Math.Floor(distance / resist);
            double dellay = totalResist * 12.5;
            double total = totalTime + dellay;
            
            if (total >= wRecord) 
            {
                Console.WriteLine($"No, he failed! He was {total-wRecord:F2} seconds slower.");
            }
            else { Console.WriteLine($" Yes, he succeeded! The new world record is {total:F2} seconds."); }

           
        }
    }
}
