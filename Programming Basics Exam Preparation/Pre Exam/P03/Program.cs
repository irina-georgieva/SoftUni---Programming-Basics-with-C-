using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int kilommeters = int.Parse(Console.ReadLine());
            double pricePackage = 0.0;

            if (type == "standard")
            {
                if (kg < 1)
                {
                    pricePackage = 3 * kilommeters;
                }
                else if (kg >= 1 && kg < 10)
                {
                    pricePackage = 5 * kilommeters;
                }
                else if (kg >= 10 && kg < 40)
                {
                    pricePackage = 10 * kilommeters;
                }
                else if (kg >= 40 && kg < 90)
                {
                    pricePackage = 15 * kilommeters;
                }
                else if (kg >= 90 && kg < 150)
                {
                    pricePackage = 20 * kilommeters;
                }
            }

            else if (type == "express")
            {
                if (kg < 1)
                {
                    pricePackage = kilommeters * kg * (0.8 * 3) + (3 * kilommeters);
                }
                else if (kg >= 1 && kg < 10)
                {
                    pricePackage = kilommeters * kg * (0.4 * 5) + (5 * kilommeters);
                }
                else if (kg >= 10 && kg < 40)
                {
                    pricePackage = kilommeters * kg * (0.05 * 10) + (10 * kilommeters);
                }
                else if (kg >= 40 && kg < 90)
                {
                    pricePackage = kilommeters * kg * (0.02 *15) + (15 * kilommeters);
                }
                else if (kg >= 90 && kg < 150)
                {
                    pricePackage = kilommeters * kg * (0.01 * 20) + (20 * kilommeters);
                }
            }

            Console.WriteLine($"The delivery of your shipment with weight of {kg:F3} kg. would cost {pricePackage/100:F2} lv.");
        }
    }
}
