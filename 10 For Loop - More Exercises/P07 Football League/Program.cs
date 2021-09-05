using System;

namespace P07
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            double sumA = 0;
            double sumB = 0;
            double sumV = 0;
            double sumG = 0;

            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sumA++;
                }
                else if (sector == "B")
                    {
                    sumB++;
                }
                else if (sector == "V")
                {
                    sumV++;
                }
                else if (sector == "G")
                {
                    sumG++;
                }      
            }

            Console.WriteLine($"{sumA / fans * 100:F2}%");
            Console.WriteLine($"{sumB / fans * 100:F2}%");
            Console.WriteLine($"{sumV / fans * 100:F2}%");
            Console.WriteLine($"{sumG / fans * 100:F2}%");
            Console.WriteLine($"{fans / (capacity*1.0) * 100:F2}%");
        }
    }
}
