﻿using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }                
            }

            int endsum = sum - max;

            if (endsum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - endsum)}");
            }
        }
    }
}
