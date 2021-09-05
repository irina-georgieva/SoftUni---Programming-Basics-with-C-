using System;

namespace P05
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string accomodation = "";
            double price = 0.0;

            if (budget <= 1000)
            {
                accomodation = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                accomodation = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.8;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.6;
                }                
            }
            else if (budget > 3000)
            {
                accomodation = "Hotel";
                price = budget * 0.9;

                if (season == "Summer")
                {
                    location = "Alaska";                 
                }
                else if (season == "Winter")
                {
                    location = "Morocco";                    
                }
            }

            Console.WriteLine($"{location} - {accomodation} - {price:F2}");
        }
    }
}
