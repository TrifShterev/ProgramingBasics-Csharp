using System;
using System.Security.Cryptography;

namespace Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double pointsStart = double.Parse(Console.ReadLine());
            string sector = Console.ReadLine();
            int turns = 0;
            double points = 0.0;
            while (sector != "bullseye")
            {
                sector = Console.ReadLine();
                turns++;
                
                
                if (pointsStart == 0)
                {

                    Console.WriteLine($"Congratulations! You won the game in {turns} moves!");
                    return;
                }                                  

                switch (sector)
                {
                    
                    case "number section":
                        points = double.Parse(Console.ReadLine());
                        pointsStart -= points;
                        break;


                    case "double ring":
                        points = double.Parse(Console.ReadLine());
                        pointsStart -= 2 * points;
                        break;

                    case "triple ring":
                        points = double.Parse(Console.ReadLine());
                        pointsStart -= 3 * points;
                        break;

                }
                if (pointsStart < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(pointsStart)}.");
                    return;
                }


            }
            Console.WriteLine($"Congratulations! You won the game with a bullseye in {turns} moves!");
            
        }
    }
}
