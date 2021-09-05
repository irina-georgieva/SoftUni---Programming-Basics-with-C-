using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int badgrades = int.Parse(Console.ReadLine());
            int sumbadgrades = 0;
            string task = Console.ReadLine();
            int tasknumber = 0;
            string lasttask = "";            
            double sumgrades = 0.0;
            int gradenumber = 0;

            while (task != "Enough")
            {
                tasknumber++;

                double grade = double.Parse(Console.ReadLine());
                sumgrades += grade;
                gradenumber++;          
                
                lasttask = task;
                
                if (grade <= 4)
                {
                    sumbadgrades++;
                    if (badgrades == sumbadgrades)
                    {
                        break;
                    }
                }
                
                task = Console.ReadLine();

            }

            if (task == "Enough")
            {
                Console.WriteLine($"Average score: {sumgrades/gradenumber:F2}");
                Console.WriteLine($"Number of problems: {tasknumber}");
                Console.WriteLine($"Last problem: {lasttask}");
            }

            if (badgrades == sumbadgrades)
            {
                Console.WriteLine($"You need a break, {sumbadgrades} poor grades.");
            }
        }
    }
}
