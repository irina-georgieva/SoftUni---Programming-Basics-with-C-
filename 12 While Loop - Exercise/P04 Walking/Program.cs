using System;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            string input = Console.ReadLine();
            int stepssum = 0;

            while (input != "Going home")
            {
                int steps = int.Parse(input);                    
                stepssum += steps;

                if (stepssum >= goal)
                {                    
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepssum - goal} steps over the goal!");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Going home")
            {
                int steps = int.Parse(Console.ReadLine());
                stepssum += steps;
                if (stepssum >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepssum - goal} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{goal - stepssum} more steps to reach goal.");
                }             
            }

        }
    }
}
