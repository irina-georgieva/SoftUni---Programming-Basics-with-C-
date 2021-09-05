using System;

namespace P05
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double budget = 0;

            double money = 0.0;
            double savings = 0.0;

            while(destination != "End")
            {
                budget = double.Parse(Console.ReadLine());

                while (savings < budget)
                {
                    money = double.Parse(Console.ReadLine());
                    savings += money;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
                savings = 0;
            }
        }
    }
}
