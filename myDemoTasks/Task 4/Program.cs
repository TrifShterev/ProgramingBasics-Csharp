using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double numStudents = double.Parse(Console.ReadLine());
            double numSeasons = double.Parse(Console.ReadLine());


            double totalRemain = 0;
            for (int i = 0; i < numSeasons; i++)
            {
               var firstExam = numStudents * 0.9;
               var secondExam = firstExam * 0.9;
               var produlzhavashi = Math.Ceiling(secondExam * 0.8);
                var prezapisali = Math.Ceiling(produlzhavashi * 0.05);
                if (numSeasons%10==3)
                {
                    prezapisali = produlzhavashi * 0.10;
                }
                 totalRemain = prezapisali + produlzhavashi;
            }
            
            Console.WriteLine($"Students: {totalRemain}");
           
        }
    }
}
