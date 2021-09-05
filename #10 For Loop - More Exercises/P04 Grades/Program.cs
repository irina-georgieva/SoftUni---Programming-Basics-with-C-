using System;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double sumtop = 0;
            double sumfive = 0;
            double sumfour = 0;
            double sumthree = 0;
            double sumgrade = 0;
            
            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sumgrade += grade;

                if (grade >= 2 && grade <= 2.99)
                {
                    sumthree++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    sumfour++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    sumfive++;
                }
                else
                {
                    sumtop++;
                }
            }

            Console.WriteLine($"Top students: {sumtop / students * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {sumfive / students * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {sumfour / students * 100:F2}%");
            Console.WriteLine($"Fail: {sumthree / students * 100:F2}%");
            Console.WriteLine($"Average: {sumgrade / students:F2}");
        }
    }
}
