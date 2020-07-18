using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int maxNum = int.MinValue ;
            while (counter<=n)
            {
                int number = int.Parse(Console.ReadLine());
                counter++;
                if (number>maxNum)
                {
                    maxNum = number;
                    
                    
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
