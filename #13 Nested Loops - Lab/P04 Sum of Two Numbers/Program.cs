using System;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicnum = int.Parse(Console.ReadLine());
            int count = 0;

            bool found = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;

                    if (i + j == magicnum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicnum})");
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicnum}");
            }
        }
    }
}
