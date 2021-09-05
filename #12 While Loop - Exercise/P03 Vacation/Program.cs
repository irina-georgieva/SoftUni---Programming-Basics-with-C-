using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionmoney = double.Parse(Console.ReadLine());
            double havemoney = double.Parse(Console.ReadLine());
            int days = 0;
            int daysspend = 0;

            while (havemoney < excursionmoney)
            {
                days++;

                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    havemoney -= money;
                    if (havemoney < 0)
                    {
                        havemoney = 0;
                    }
                    
                    daysspend++;
                    
                    if (daysspend == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                }
                else if (action == "save")
                {
                    havemoney += money;
                    daysspend = 0;
                }   
            }

            if (havemoney >= excursionmoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }


        }
    }
}
