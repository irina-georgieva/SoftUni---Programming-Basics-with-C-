using System;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double n = double.Parse(Console.ReadLine());

                double oddSum = 0;
                double oddMin = double.MaxValue;
                double oddMax = double.MinValue;
                double evenMin = double.MaxValue;
                double evenMax = double.MinValue;
                double evenSum = 0;

                for (int i = 1; i <= n; i++)
                {
                    double num = double.Parse(Console.ReadLine());

                    if (i % 2 == 0)
                    {
                        evenSum += num;

                        if (num > evenMax)
                        {
                            evenMax = num;

                        }
                        if (num < evenMin)
                        {
                            evenMin = num;

                        }
                    }
                    else
                    {
                        oddSum += num;

                        if (num > oddMax)
                        {
                            oddMax = num;
                        }
                        if (num < oddMin)
                        {
                            oddMin = num;
                        }
                    }

                }


                if (oddSum == 0)
                {
                    Console.WriteLine($"OddSum={oddSum:f2},");
                    Console.WriteLine($"OddMin=No,");
                    Console.WriteLine($"OddMax=No,");
                    Console.WriteLine($"EvenSum={evenSum:f2},");
                    Console.WriteLine($"EvenMin={evenMin:f2},");
                    Console.WriteLine($"EvenMax={evenMax:f2}");

                }
                else if (evenSum == 0)
                {
                    Console.WriteLine($"OddSum={oddSum:f2},");
                    Console.WriteLine($"OddMin={oddMin:f2},");
                    Console.WriteLine($"OddMax={oddMax:f2},");
                    Console.WriteLine($"EvenSum={evenSum:f2},");
                    Console.WriteLine($"EvenMin=No,");
                    Console.WriteLine($"EvenMax=No");

                }

                else
                {
                    Console.WriteLine($"OddSum={oddSum:f2},");
                    Console.WriteLine($"OddMin={oddMin:f2},");
                    Console.WriteLine($"OddMax={oddMax:f2},");
                    Console.WriteLine($"EvenSum={evenSum:f2},");
                    Console.WriteLine($"EvenMin={evenMin:f2},");
                    Console.WriteLine($"EvenMax={evenMax:f2}");
                }

            }
        }
    }
}
