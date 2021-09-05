using System;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string car = "";
            double pricecar = 0.0;
            string carclass = "";

            if (budget <= 100)
            {
                carclass = "Economy class";
                if (season == "Summer")
                { 
                    car = "Cabrio";
                    pricecar = 0.35 * budget;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    pricecar = 0.65 * budget;
                }
            }
            else if (budget >100 && budget <= 500)
            {
                carclass = "Compact class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    pricecar = 0.45 * budget;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    pricecar = 0.8 * budget;
                }
            }
            else if (budget > 500)
            {
                carclass = "Luxury class";
                car = "Jeep";
                pricecar = 0.9 * budget;
            }

            Console.WriteLine(carclass);
            Console.WriteLine($"{car} - {pricecar:F2}");
        }
    }
}
