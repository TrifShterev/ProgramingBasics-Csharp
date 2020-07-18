using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinationNum = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinationNum++;
                    if (i + j == magicNum)
                    {
                        
                        Console.WriteLine($"Combination N:{combinationNum} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationNum} combinations - neither equals {magicNum}");

        }
    }
}
