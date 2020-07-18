using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            while (input != "Stop")
            {
             int   inputNum = int.Parse(input);
                sum += inputNum;
                input = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
