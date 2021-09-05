using System;

namespace P08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double value = a+b;
            double newvalue = value;
            double maxdiff = 0;

            for (int i = 1; i < n; i++)
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());

                newvalue= a + b;
                double diff = Math.Abs(newvalue - value);
                if (diff > maxdiff)
                {
                    maxdiff = diff;
                }

                value = newvalue;
            }

            if (maxdiff != 0)
            {
                Console.WriteLine($"No, maxdiff={maxdiff}");
            }
            else
            {
                Console.WriteLine($"Yes, value={value}");
            }
        }
    }
}
