using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double sum = 0;

            while (sum < num1)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;                
            }

            Console.WriteLine(sum);
        }
    }
}
