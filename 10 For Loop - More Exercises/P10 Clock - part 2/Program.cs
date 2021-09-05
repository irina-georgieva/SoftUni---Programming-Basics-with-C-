using System;

namespace P09
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = -1;
            int minute = -1;
            int seconds = 0;

            for (int i = 0; i < 86400; i++)
            {
                
                if (i % 60 == 0)
                {
                  minute++;
                }
                if (i % 3600 == 0)
                {
                    hour++;
                    minute = 0;
                }
                seconds = i % 60;                

                Console.WriteLine($"{hour} : { minute} : {seconds}");

            }
        }
    }
}
