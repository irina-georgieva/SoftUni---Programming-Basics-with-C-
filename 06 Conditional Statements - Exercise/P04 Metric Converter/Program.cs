using System;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string edinica = Console.ReadLine();
            string endedinica = Console.ReadLine();

            if (edinica == "mm")
            {
                if (endedinica == "m")
                {
                    Console.WriteLine($"{n * 0.001:F3}");
                }

                else if (endedinica == "cm") 
                {
                    Console.WriteLine($"{n * 0.1:F3}");
                }
             }

            else if (edinica == "cm")
            {
                if (endedinica == "m")
                {
                    Console.WriteLine($"{n * 0.01:F3}");
                }

                else if (endedinica == "mm")
                {
                    Console.WriteLine($"{n * 10:F3}");
                }
            }

            else if (edinica == "m")
            {
                if (endedinica == "cm")
                {
                    Console.WriteLine($"{n * 100:F3}");
                }

                else if (endedinica == "mm")
                {
                    Console.WriteLine($"{n * 1000:F3}");
                }
            }
        }
    }
}
