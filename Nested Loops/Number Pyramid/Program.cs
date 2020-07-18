using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Брояч
            int current = 1;

            //Флаг
            bool flag = false;

            //Определя колко реда да се отпечатат
            for (int rows = 1; rows <= n; rows++)
            {
                //Определя колко числа ще се печатат на ред
                for (int numPerRow = 1; numPerRow <= rows; numPerRow++)
                {

                    if (current>n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write(current+" ");
                    current++;
                   
                }
                if (flag)
                {
                    break;
                }
                Console.WriteLine();
            }
            
        }
    }
}
