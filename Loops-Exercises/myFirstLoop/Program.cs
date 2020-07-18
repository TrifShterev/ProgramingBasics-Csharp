using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            double gr1 = 0;
            double gr2 = 0;
            double gr3 = 0;
            double gr4 = 0;
            double gr5 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200)
                {
                    gr1++;
                }
                else if (currentNumber >= 200 && currentNumber <= 399) {
                    gr2++;
                }
                else if (currentNumber >=400 && currentNumber <= 599)
                {
                    gr3++;
                }
                else if (currentNumber >= 600 && currentNumber <= 799)
                {
                    gr4++;
                }
                else { gr5++; }
                            }
          var percentage1 = gr1 * 100 / n;
          var percentage2 = gr2 * 100 / n;
          var percentage3 = gr3 * 100 / n;
          var percentage4 = gr4 * 100 / n;
          var percentage5 = gr5 * 100 / n;



            Console.WriteLine("{0:F2}%",percentage1);
            Console.WriteLine("{0:F2}%", percentage2);
            Console.WriteLine("{0:F2}%",percentage3);
            Console.WriteLine("{0:F2}%",percentage4);
            Console.WriteLine("{0:F2}%", percentage5);
        }
    }
}
