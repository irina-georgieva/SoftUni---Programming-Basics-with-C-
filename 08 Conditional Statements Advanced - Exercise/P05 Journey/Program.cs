using System;

namespace P05
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string accomodation = "";
            double moneyspent = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    moneyspent = budget * 0.3;
                    accomodation = "Camp";
                }
                else if (season == "winter")
                {
                    moneyspent = budget * 0.7;
                    accomodation = "Hotel";
                }
            }

            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                
                if (season == "summer")
                {
                    moneyspent = budget * 0.4;
                    accomodation = "Camp";
                }
                else if (season == "winter")
                {
                    moneyspent = budget * 0.8;
                    accomodation = "Hotel";
                }
            }

            else if (budget > 1000)
            {
                destination = "Europe";
                moneyspent = budget * 0.9;
                accomodation = "Hotel";               
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {Math.Round(moneyspent,2):F2}");
        }
    }
}
