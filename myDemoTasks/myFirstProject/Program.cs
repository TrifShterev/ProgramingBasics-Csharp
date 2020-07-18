using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

        
        int numStudents = int.Parse(Console.ReadLine());
        int numTasks = int.Parse(Console.ReadLine());

            double tasks = numStudents *Math.Ceiling( numTasks * 2.8);
            
            double extraTasks = numStudents * (numTasks/ 3);
            
            double totalTasks = tasks + extraTasks;
            double memory = 5 * Math.Ceiling(totalTasks / 10);

            Console.WriteLine($"{memory} KB needed");
            Console.WriteLine($"{totalTasks} submissions");

        }
    }

}
