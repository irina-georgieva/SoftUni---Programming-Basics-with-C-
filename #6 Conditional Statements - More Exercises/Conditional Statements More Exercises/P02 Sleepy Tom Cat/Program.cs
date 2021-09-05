using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int holiday = int.Parse(Console.ReadLine());

            int workdays = 365 - holiday;
            int minplay = workdays * 63 + holiday * 127;

            int difference = Math.Abs(30000 - minplay);
            
            int hourdifference = difference / 60;
            int endmindifference = difference % 60;


            
            if (minplay >= 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hourdifference} hours and {endmindifference} minutes more for play");
            }

            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hourdifference} hours and {endmindifference} minutes less for play");

            }

        }
    }
}
