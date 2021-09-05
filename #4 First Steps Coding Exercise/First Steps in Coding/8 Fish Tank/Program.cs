using System;

namespace _8_Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double restvolume = volume - volume * percent / 100;

            double liters = restvolume / 1000.0;

            Console.WriteLine(liters);



        }
    }
}
