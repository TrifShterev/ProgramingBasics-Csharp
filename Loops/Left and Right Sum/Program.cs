using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            
            for (int i = 0; i < num; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < num; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }
            
            if (leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                var sum = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {sum}");
            }
            
        }
    }
}
