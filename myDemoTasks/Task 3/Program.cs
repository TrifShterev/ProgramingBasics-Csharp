using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int compl = int.Parse(Console.ReadLine());
            int rotation = int.Parse(Console.ReadLine());
            int numPages = int.Parse(Console.ReadLine());

            bool legacy = compl >= 80 && rotation >= 80 && numPages >= 8;
            bool master = compl >= 80 && rotation <= 10;
            bool hard = rotation >= 50 && numPages >= 2;
            bool easy = compl <= 30 && numPages <= 1;
            bool elementary = compl <= 10;

            if (legacy)
            {
                Console.WriteLine("Legacy");
            }
            else if (master)
            {
                Console.WriteLine("Master");
            }
            else if (hard)
            {
                Console.WriteLine("Hard");
            }
            else if (easy)
            {
                Console.WriteLine("Easy");
            }
            else if (elementary)
            {
                Console.WriteLine("Elementary");
            }
            else
            {
                Console.WriteLine("Regular");
            }
           
           
        }
    }
}
