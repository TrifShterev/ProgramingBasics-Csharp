using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int capacityOFBooks =int.Parse( Console.ReadLine());
            int attempts = 0;

            while (capacityOFBooks>0)
            {
                
                string name = Console.ReadLine();

                if (name==book)
                {
                    Console.WriteLine($"You checked {attempts} books and found it.");
                    return;
                }
                capacityOFBooks--;
                attempts++;
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {attempts} books.");
        }
    }
}
