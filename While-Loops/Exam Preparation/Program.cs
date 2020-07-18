using System;
using System.Threading.Tasks;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double badEvaluationsNum = double.Parse(Console.ReadLine());
            double grades = 0;
            double tasksCompleted = 0;
           
            string lastTask = "";
            string task = Console.ReadLine();
            while (task !="Enough")
            {                        
                double evaluation = double.Parse(Console.ReadLine());
                grades += evaluation;
                
                if (evaluation<=4)
                {
                    badEvaluationsNum--;

                    if (badEvaluationsNum==0)
                    {
                        break;
                    }
                }
                tasksCompleted++;
                lastTask =task;
                task = Console.ReadLine();
            }
              if (task == "Enough")
            {
                double averageGrade = grades / tasksCompleted;
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {tasksCompleted}");
                Console.WriteLine($"Last problem: {lastTask}");


            }
            else
            {
                Console.WriteLine($"You need a break, {tasksCompleted} poor grades.");
            }
            
        }
    }
}
