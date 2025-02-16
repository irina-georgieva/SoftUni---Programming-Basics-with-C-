﻿using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                { money -= 12000; }

                else
                { money -= 12000 + 50 * (i - 1800 + 18); }
            }

            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):F2} dollars to survive.");
            }
        }
    }
}
