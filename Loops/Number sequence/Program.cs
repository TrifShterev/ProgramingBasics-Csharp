﻿using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            for (int i = 1;i<=num;i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum>maxNum)
                {
                    maxNum=currentNum;

                }
                else if (currentNum<minNum)
                {
                    minNum = currentNum;
                }
                
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");


        }
    }
}
