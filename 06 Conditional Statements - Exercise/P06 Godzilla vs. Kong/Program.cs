using System;

namespace P06
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int compars = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double dekor = budget * 0.1;
            double priceclothes = compars * clothes;

            if (compars > 150)
            {
                priceclothes = priceclothes - priceclothes * 0.1;
            }

            double costs = priceclothes + dekor;

            if (costs > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs " + ($"{costs - budget:F2}") + " leva more.");
            }

            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with " + ($"{budget - costs:F2}") + " leva left.");
            }
            
        }
    }
}
