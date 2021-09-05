using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double oddmin = double.MaxValue;
            double oddmax = double.MinValue;

            double evenmin = double.MaxValue;
            double evenmax = double.MinValue;
            
            double oddsum = 0;
            double evensum = 0;            
            

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                             
                if (i % 2 != 0)
                {
                    oddsum += num;

                    if (num < oddmin)
                    {
                        oddmin = num;
                    }
                    if (num > oddmax)
                    {
                        oddmax = num;
                    }
                }
                else if (i % 2 == 0)
                {
                    evensum += num;

                    if (num > evenmax)
                    {
                        evenmax = num;
                    }
                    if (num < evenmin)
                    {
                        evenmin = num;
                    }
                }

            }

            Console.WriteLine($"OddSum={oddsum:F2},");

            if (oddmin == double.MaxValue)
            { Console.WriteLine("OddMin=No,"); }
            else
            { Console.WriteLine($"OddMin={oddmin:F2},"); }

            if (oddmax == double.MinValue)
            { Console.WriteLine("OddMax=No,"); }
            else
            { Console.WriteLine($"OddMax={oddmax:F2},"); }

            Console.WriteLine($"EvenSum={evensum:F2},");

            if (evenmin == double.MaxValue)
            { Console.WriteLine("EvenMin=No,"); }
            else
            { Console.WriteLine($"EvenMin={evenmin:F2},"); }

            if (evenmax == double.MinValue)
            { Console.WriteLine("EvenMax=No"); }
            else
            { Console.WriteLine($"EvenMax={evenmax:F2}"); }
        }                     
    }
}
