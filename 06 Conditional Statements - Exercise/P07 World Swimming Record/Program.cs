using System;

namespace P07
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double onemeter = double.Parse(Console.ReadLine());

            double nresistance = Math.Floor(distance / 15);
            double resistance = (nresistance * 12.5);

            double time = (distance * onemeter) + resistance;

            if (time < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(time):F2} seconds.");
            }

            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(record - time):F2} seconds slower.");
            }
           
        }
    }
}
