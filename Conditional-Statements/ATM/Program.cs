using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Threading;

namespace Demo
    {
        class Program
        {
            static void Main(string[] args)
            {
                double balance = 10000000;
                Console.WriteLine("Insert your card!");
                Console.WriteLine("Choose one of the following options:");
                string option = Console.ReadLine();
                // withdraw, check balance, deposit

                if (option == "withdraw")
                {
                    Console.WriteLine("How much money will you withdraw?");
                    int amountToWithdraw = int.Parse(Console.ReadLine());

                    if (balance >= amountToWithdraw)
                    {
                        Console.Write("PIN code: ");
                        int pinCode = int.Parse(Console.ReadLine());

                        if (pinCode == 1234)
                        {
                            balance -= amountToWithdraw;
                            Console.WriteLine(balance);
                        }
                        else
                        {
                            Console.WriteLine("Invalid pin!");
                        }
                    }
                    balance -= 2;
                }
                else if (option == "check balance")
                {
                    Console.Write("PIN code: ");
                    int pinCode = int.Parse(Console.ReadLine());

                    if (pinCode == 1234)
                    {
                        Console.WriteLine($"Your balance is {balance} lv");
                    }
                    else
                    {
                        Console.WriteLine("Invalid pin!");
                    }
                    balance -= 0.50;
                }
                else if (option == "deposit")
                {
                    Console.WriteLine("How much money do you want to deposit?");
                    int deposit = int.Parse(Console.ReadLine());

                    Console.Write("PIN code: ");
                    int pinCode = int.Parse(Console.ReadLine());
                    if (pinCode == 1234)
                    {
                        balance += deposit;
                        Console.WriteLine(balance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid pin!");
                    }
                    balance -= 1;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                }
            }
        }
    }
}
    }
}
