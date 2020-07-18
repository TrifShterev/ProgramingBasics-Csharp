using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();



            while (name != "Midnight")
            {
                bool flag = false;
                double totalPoints = 0;
                string lastStudent = "";
                lastStudent = name;
                for (int i = 0; i < 6; i++)
                {
                    double points = double.Parse(Console.ReadLine());
                    if (points < 0)
                    {

                        flag = true;
                        Console.WriteLine($"{name} was cheating!");
                        name = Console.ReadLine();
                        break;
                    }
                    totalPoints += points;
                }

                if (flag)
                {
                    continue;
                }

                double averagePoints = Math.Floor((totalPoints / 600) * 100);
                double averageGrade = averagePoints * 0.06;
                if (averageGrade >= 5)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("|   CERTIFICATE   |");
                    Console.WriteLine($"|    {averageGrade:F2}/6.00    |");
                    Console.WriteLine("===================");
                    Console.WriteLine($"Issued to {lastStudent}");
                }
                else if (averageGrade < 5 && averageGrade >= 3)
                {
                    Console.WriteLine($"{lastStudent} - {averageGrade:F2}");
                }
                else if (averageGrade < 3)
                {
                    averageGrade = 2.00;
                    Console.WriteLine($"{lastStudent} - {averageGrade:F2}");
                }
                name = Console.ReadLine();


            }
        }   
    }
}
