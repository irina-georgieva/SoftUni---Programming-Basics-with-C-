using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());
            int examHourInMinutes = examHour * 60;
            int exam = examHourInMinutes + examMinute;
            int arriveHourInMinutes = arriveHour * 60;
            int arrive = arriveHourInMinutes + arriveMinute;
            if (arrive > exam)
            {
                int lateTime = arrive - exam;
                if (lateTime <= 59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{lateTime} minutes after the start");
                }
                else if (lateTime >= 60)
                {
                    int lateTimeHour = lateTime / 60;
                    int lateTimeMinutes = lateTime % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{lateTimeHour}:{lateTimeMinutes:d2} hours after the start");
                }
            }
            else if (arrive < exam)
            {
                int earlyTime = exam - arrive;
                if (earlyTime <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{earlyTime} minutes before the start");
                }
                else if (earlyTime > 30 && earlyTime <= 59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{earlyTime} minutes before the start");
                }
                else if (earlyTime >= 60)
                {
                    int earlyTimeHour = earlyTime / 60;
                    int earlyTimeMinutes = earlyTime % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{earlyTimeHour}:{earlyTimeMinutes:d2} hours before the start");

                }

            }
            else if (arrive == exam)
            {
                Console.WriteLine("On time");
            }
            
        }
    }
}