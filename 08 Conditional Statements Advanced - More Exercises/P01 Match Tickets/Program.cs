using System;

namespace ConditionalStatementsAdvMoreExcer
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            double people = double.Parse(Console.ReadLine());

            double priceticket = 0.0;
            double transport = 0.0;

            if (category == "VIP")
            { priceticket = 499.99; }
            else if (category == "Normal")
            { priceticket = 249.99; }

            if (people <= 4)
            {
                transport = budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = budget * 0.6;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = budget * 0.5;
            }
            else if (people >= 25 && people <= 49)
            {
                transport = budget * 0.4;
            }
            else if (people >= 50)
            {
                transport = budget * 0.25;
            }

            double costtickets = people * priceticket;
            double moneyleft = budget - transport;

            if (moneyleft > costtickets)
            {
                Console.WriteLine($"Yes! You have {(moneyleft - costtickets):F2} leva left.");
            }
            else if (moneyleft <= costtickets)
            {
                Console.WriteLine($"Not enough money! You need {(costtickets - moneyleft):F2} leva.");
            }
        }
    }
}
