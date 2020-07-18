using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            for (int i = 0; i < num; i++)
            {
                var element = int.Parse(Console.ReadLine());

                if (i % 2 ==0)
                {
                    even += element;
                }
                else
                {
                    odd += element;
                }
                
            }
            
            if (odd-even== 0)
            {
                
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
                

            }
            else
            {
                var diference = Math.Abs(even - odd);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diference}");
                
            }

        }
    }
}
