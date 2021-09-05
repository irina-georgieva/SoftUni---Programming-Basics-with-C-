using System;

namespace P09
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holiday = int.Parse(Console.ReadLine());
            int homeweekend = int.Parse(Console.ReadLine());

            double Sofia = 48 - homeweekend;
            double playSofia = Sofia * 3/4;

            double holidaySofia = holiday*1.0 * 2 / 3;

            double playdays = playSofia + homeweekend + holidaySofia;
            
            if (year == "leap")
            {
                playdays += playdays * 0.15;
            }

            Console.WriteLine(Math.Floor(playdays));
        
        }
    }
}
