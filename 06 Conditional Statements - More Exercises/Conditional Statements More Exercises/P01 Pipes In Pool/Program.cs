using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double LP1 = P1 * H;
            double LP2 = P2 * H;

            double Liters = LP1 + LP2;
            double percentP1 = (LP1 / Liters) * 100;
            double percentP2 = (LP2 / Liters) * 100;


            if (Liters <= V)
            {
                double percentLiters = (Liters / V) * 100;
                Console.WriteLine($"The pool is {percentLiters:F2}% full. Pipe 1: {percentP1:F2}%. Pipe 2: {percentP2:F2}%.");
            }

            else
            {
                Console.WriteLine($"For {H:F2} hours the pool overflows with {(Liters - V):F2} liters.");
            }
        }
    }
}
