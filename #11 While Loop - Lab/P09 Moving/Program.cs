using System;

namespace P09
{
    class Program
    {
        static void Main(string[] args)
        {
            int bright = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = bright * length * height;
            double restvolume = 0;

            string input = Console.ReadLine();

            int boxessum = 0;

            while (input != "Done")
            {
                int boxes = int.Parse(input);
                boxessum += boxes;
                
                restvolume = volume - boxessum;

                if (restvolume <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(restvolume)} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }

            
            if (restvolume > 0)
            {
                Console.WriteLine($"{restvolume} Cubic meters left.");
            }
        }
    }
}
