using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numDogs = double.Parse(Console.ReadLine());
            double pets = double.Parse(Console.ReadLine());
            double dogFood = 2.5;
            double petsFood = 4;
            double total = ((numDogs * dogFood) + (petsFood * pets));
            Console.WriteLine("{0:F2} lv." ,total);
        }
    }
}
