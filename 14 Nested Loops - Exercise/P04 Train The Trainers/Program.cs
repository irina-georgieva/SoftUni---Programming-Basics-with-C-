using System;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presiName = Console.ReadLine();
            double sumScore = 0;

            int countPresi = 0;
            double sumAverageScore = 0.0;

            while (presiName != "Finish")
            {
                countPresi++;

                for (int i = 1; i <= judges; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    sumScore += score;
                }

                double averageScore = sumScore / judges;
                sumAverageScore += averageScore;

                Console.WriteLine($"{presiName} - {averageScore:F2}.");
                sumScore = 0.0;
                presiName = Console.ReadLine();
            }

            if (presiName == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {sumAverageScore / countPresi:F2}.");
            }

        }
    }
}
