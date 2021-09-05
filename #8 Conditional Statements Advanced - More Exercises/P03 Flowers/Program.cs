using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numhrisantem = int.Parse(Console.ReadLine());
            int numroses = int.Parse(Console.ReadLine());
            int numtulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string day = Console.ReadLine();

            double pricehrisantem = 0.0;
            double priceroses = 0.0;
            double pricetulips = 0.0;

            if (season == "Spring" || season == "Summer")
            {
                pricehrisantem = 2;
                priceroses = 4.1;
                pricetulips = 2.5;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                pricehrisantem = 3.75;
                priceroses = 4.50;
                pricetulips = 4.15;
            }

            if (day == "Y")
            { 
                pricehrisantem += pricehrisantem * 0.15;
                priceroses += priceroses * 0.15;
                pricetulips += pricetulips * 0.15;
            }

            double costbouqet = (numhrisantem * pricehrisantem) + (numroses * priceroses) + (numtulips * pricetulips);

            if ( numtulips > 7 && season == "Spring")
            {
                costbouqet -= costbouqet * 0.05;                
            }
            else if (numroses >= 10 && season == "Winter")
            {
                costbouqet -= costbouqet * 0.1;                
            }

            if (numhrisantem + numroses + numtulips > 20)
            {
                costbouqet -= costbouqet * 0.2;
            }

            Console.WriteLine($"{costbouqet + 2:F2}");
        }
    }
}
