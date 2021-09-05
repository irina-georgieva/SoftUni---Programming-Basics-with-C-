using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirtPrice = double.Parse(Console.ReadLine());

            double ballPrice = double.Parse(Console.ReadLine());

            double shortsPrice = 0.75 * shirtPrice;
            double socksPrice = 0.20 * shortsPrice;
            double shoesPrice = 2 * (shortsPrice + shirtPrice);

            double costs = shirtPrice + shortsPrice + socksPrice + shoesPrice;
            double costsLoyal = costs - costs * 0.15;

            if (costsLoyal >= ballPrice)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {costsLoyal:F2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {ballPrice - costsLoyal:F2} lv. more.");
            }
        }
    }
}
