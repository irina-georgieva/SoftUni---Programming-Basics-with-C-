using System;

namespace P11
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingm = double.Parse(Console.ReadLine());
            double toys = double.Parse(Console.ReadLine());

            double sumtoys = 0;
            double summoney = 0;
            

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    summoney += - 1 + (i/2)*10;
                }
                else
                {
                    sumtoys += toys;
                }

            }

           double money = summoney + sumtoys;

            if (money >= washingm)
            {
                Console.WriteLine($"Yes! {money - washingm:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingm - money:F2}");
            }            
        }
    }
}
