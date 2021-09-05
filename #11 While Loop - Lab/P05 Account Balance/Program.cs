using System;

namespace P05
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            double sum = 0.0;

            while (n != "NoMoreMoney")
            {
                double input = double.Parse(n);
                if (input < 0)
                {
                    Console.WriteLine("Invalid operation!");                    
                    break;
                }

                sum += input;
                Console.WriteLine($"Increase: {input:F2}");
                n = Console.ReadLine();                
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
