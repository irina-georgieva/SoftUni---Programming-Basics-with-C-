using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transportPrice = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());

            double nightcosts = 20 * nights;
            double transportcosts = 1.60 * transportPrice;
            double ticketcosts = 6 * tickets;

            double costs = nightcosts + transportcosts + ticketcosts;
            double peopleCosts = people * costs;

            double Endprice = peopleCosts + peopleCosts * 0.25;

            Console.WriteLine($"{Endprice:f2}");
        }
    }
}
