using System;

namespace P07
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double pricestudio = 0.0;
            double priceapartment = 0.0;


            if (season == "May" || season == "October")
            {
                pricestudio = 50;
                priceapartment = 65;
            }
            else if (season == "June" || season == "September")
            {
                pricestudio = 75.20;
                priceapartment = 68.70;
            }            
            else if (season == "July" || season == "August")
            {
                pricestudio = 76;
                priceapartment = 77;
            }


            if (season == "May" || season == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    pricestudio -= pricestudio * 0.05;
                }
                else if (nights > 14)
                {
                    pricestudio -= pricestudio * 0.3;
                    priceapartment -= priceapartment * 0.1;
                }
            }

            else if (season == "June" || season == "September" && nights > 14)
            {
                pricestudio -= pricestudio * 0.2;
                priceapartment -= priceapartment * 0.1;
            }

            else if (nights > 14)
            {
                priceapartment -= priceapartment * 0.1;
            }

            double endpricestudio = nights * pricestudio;
            double endpriceapartment = nights * priceapartment;

            Console.WriteLine($"Apartment: {endpriceapartment:F2} lv.");
            Console.WriteLine($"Studio: {endpricestudio:F2} lv.");


        }
    }
}
