using System;

namespace P05
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());
            double sumzero = 0;
            double sumten = 0;
            double sumtwenty = 0;
            double sumthirty = 0;
            double sumfourty = 0;
            double suminvalid = 0;
            double sumresult = 0;

            for (int i = 1; i <= rounds; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (points >= 0 && points <= 9)
                {
                    sumzero += 1;
                    sumresult += 0.2 * points;
                }
                else if (points >= 10 && points <= 19)
                {
                    sumten += 1;
                    sumresult += 0.3 * points;
                }
                else if (points >= 20 && points <= 29)
                {
                    sumtwenty += 1;
                    sumresult += 0.4 * points;
                }
                else if (points >= 30 && points <= 39)
                {
                    sumthirty += 1;
                    sumresult += 50;
                }
                else if (points >= 40 && points <= 50)
                {
                    sumfourty += 1;
                    sumresult += 100;
                }
                else
                {
                    suminvalid += 1;
                    sumresult /= 2;
                }
            }
            Console.WriteLine($"{sumresult:F2}");
            Console.WriteLine($"From 0 to 9: {sumzero / rounds * 100:F2}%");
            Console.WriteLine($"From 10 to 19: {sumten / rounds * 100:F2}%");
            Console.WriteLine($"From 20 to 29: {sumtwenty / rounds * 100:F2}%");
            Console.WriteLine($"From 30 to 39: {sumthirty / rounds * 100:F2}%");
            Console.WriteLine($"From 40 to 50: {sumfourty / rounds * 100:F2}%");
            Console.WriteLine($"Invalid numbers: {suminvalid / rounds * 100:F2}%");

        }
    }
}
