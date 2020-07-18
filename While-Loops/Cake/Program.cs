using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakelenght = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());

            int cakeArea = cakelenght * cakeWidth;

            while (cakeArea>0)
            {
                string pieceOfCake =Console.ReadLine();
               
                if (pieceOfCake=="STOP")
                {
                    Console.WriteLine($"{cakeArea} pieces are left.");
                    return;
                }
                int cutedPieceOfCake = int.Parse(pieceOfCake);
                cakeArea -= cutedPieceOfCake;
            }
            Console.WriteLine($"No more cake left! You need {Math.Abs(cakeArea)} pieces more.");
        }
    }
}
