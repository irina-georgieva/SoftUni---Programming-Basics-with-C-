using System;

namespace _3_Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());

            double natrupanalihva = deposit * lihva / 100;
            double month = natrupanalihva / 12;

            Console.WriteLine(deposit + (time * month));
        }
    }
}
