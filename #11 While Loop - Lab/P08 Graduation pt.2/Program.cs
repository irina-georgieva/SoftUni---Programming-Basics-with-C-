using System;

namespace P08
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int clases = 1;
            double averageGrade = 0.0;
            int count = 0;

            while (clases <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    count++;
                }
                if (count == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {clases-1} grade");
                    break;
                }
                averageGrade += grade;
                clases++;
            }

            if (count < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade / 12:F2}");
            }
        }
    }
}
