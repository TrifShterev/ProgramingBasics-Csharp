﻿using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            if (age>=16)
            {
                switch (sex)
                {
                    case "m":
                        Console.WriteLine("Mr.");
                        break;
                    case "f":
                        Console.WriteLine("Ms.");
                        break;
                                       
                }

            }
            else if (age<16)
            {
                switch (sex)
                {
                    case "m":
                        Console.WriteLine("Master");
                        break;
                    case "f":
                        Console.WriteLine("Miss");
                        break;

                }
            }
            

            
        }
    }
}
