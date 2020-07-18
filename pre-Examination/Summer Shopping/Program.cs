using System;

namespace Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine());

            double umbrela = 2 * towelPrice / 3;
            double shoes = umbrela * 0.75;
            double beachBag = (towelPrice + shoes) / 3;

            double totalPrice = towelPrice + umbrela + shoes + beachBag;
            double discountedPrice = totalPrice -(totalPrice*discountPercentage / 100);

            double total = buget - discountedPrice;
            if (total>=0)
            {
                Console.WriteLine($"Annie's sum is {discountedPrice:F2} lv. She has {total:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {discountedPrice:F2} lv. She needs {Math.Abs(total):F2} lv. more.");
            }
            

        }
    }
}
