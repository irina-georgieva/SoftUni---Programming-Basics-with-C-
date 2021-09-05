using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumbus = 0;
            double sumtruck = 0;
            double sumtrain = 0;

            for (int i = 1; i <= n; i++)
            {
                int tones = int.Parse(Console.ReadLine());

                if (tones <= 3)
                {
                    sumbus += tones;
                }
                else if (tones >= 4 && tones <= 11)
                {
                    sumtruck += tones;
                }
                else
                {
                    sumtrain += tones;
                }
            }

            double sumtones = sumbus + sumtruck + sumtrain;

            Console.WriteLine($"{(sumbus * 200 + sumtruck * 175 + sumtrain * 120) / sumtones:F2}");
            Console.WriteLine($"{sumbus / sumtones * 100:F2}%");
            Console.WriteLine($"{sumtruck / sumtones * 100:F2}%");
            Console.WriteLine($"{sumtrain / sumtones * 100:F2}%");


        }
    }
}
