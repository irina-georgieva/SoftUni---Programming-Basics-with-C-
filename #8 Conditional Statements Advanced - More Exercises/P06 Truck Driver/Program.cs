using System;

namespace P06
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmmonth = double.Parse(Console.ReadLine());

            double kmprice = 0.0;

            if (kmmonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                { kmprice = 0.75; }
                else if (season == "Summer")
                { kmprice = 0.9; }
                else if (season == "Winter")
                { kmprice = 1.05; }
            }
            else if (kmmonth > 5000 && kmmonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                { kmprice = 0.95; }
                else if (season == "Summer")
                { kmprice = 1.1; }
                else if (season == "Winter")
                { kmprice = 1.25; }
            }
            else if (kmmonth > 10000 && kmmonth <= 20000)
            {
                kmprice = 1.45; 
            }

            double kmwin = kmmonth * kmprice * 4;
            double money = kmwin - (kmwin * 0.1);

            Console.WriteLine($"{money:F2}");   
        }
    }
}
