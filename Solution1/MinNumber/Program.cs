using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int n = int.Parse(Console.ReadLine());
                int counter = 1;
                int minNum = int.MaxValue;
                while (counter <= n)
                {
                    int number = int.Parse(Console.ReadLine());
                    counter++;
                    if (number < minNum)
                    {
                        minNum = number;


                    }
                }
                Console.WriteLine(minNum);
            }
        }
    }

