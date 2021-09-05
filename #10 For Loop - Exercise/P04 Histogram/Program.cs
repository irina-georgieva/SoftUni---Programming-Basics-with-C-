using System;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1sum = 0.00;
            double p2sum = 0.00;
            double p3sum = 0.00;
            double p4sum = 0.00;
            double p5sum = 0.00;


            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1sum += 1;
                }
                else if (num >= 200 && num < 400)
                {
                    p2sum += 1;
                }
                else if (num >= 400 && num < 600)
                {
                    p3sum += 1;
                }
                else if (num >= 600 && num < 800)
                {
                    p4sum += 1;
                }
                else
                {
                    p5sum += 1;
                }                
            }
            double p1 = p1sum / n * 100;
            double p2 = p2sum / n * 100;
            double p3 = p3sum / n * 100;
            double p4 = p4sum / n * 100;
            double p5 = p5sum / n * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
