using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int sumtreated = 0;
            int sumuntreated = 0;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && sumuntreated > sumtreated)
                {
                    doctors++;
                }

                if (patients <= doctors)
                {
                    sumtreated += patients;
                }
                if (patients > doctors)
                {
                    sumtreated += doctors;
                    sumuntreated += patients - doctors;
                }

            }
            Console.WriteLine($"Treated patients: {sumtreated}.");
            Console.WriteLine($"Untreated patients: {sumuntreated}.");
        }
    }
}
