using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                int numA = int.Parse(Console.ReadLine());
                sum += numA;
            }
            Console.WriteLine(sum);
        }
    }
}
