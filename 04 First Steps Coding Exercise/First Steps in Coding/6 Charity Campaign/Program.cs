using System;

namespace _6_Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double baker = double.Parse(Console.ReadLine());
            double cake = double.Parse(Console.ReadLine());
            double waffle = double.Parse(Console.ReadLine());
            double pancake = double.Parse(Console.ReadLine());

            double sumcake = cake * 45;
            double sumwaffle = waffle * 5.80;
            double sumpancake = pancake * 3.20;

            double sumsweet = (sumcake + sumwaffle + sumpancake) * baker;
            double sum = sumsweet * days;
            double cost = 1/8.0 * sum;

            Console.WriteLine(sum - cost);

        }
    }
}
