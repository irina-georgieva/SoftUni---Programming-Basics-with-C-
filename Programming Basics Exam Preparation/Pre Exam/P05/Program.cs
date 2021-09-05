using System;

namespace P05
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayTarget = int.Parse(Console.ReadLine());
            double sumMoney = 0.0;
            

            while(sumMoney < dayTarget)
            {
                string service = Console.ReadLine();
                if (service == "haircut")
                {
                    string type = Console.ReadLine();
                    if (type == "mens")
                    {
                        sumMoney += 15;
                    }
                    else if (type == "ladies")
                    {
                        sumMoney += 20;
                    }
                    else if (type == "kids")
                    {
                        sumMoney += 10;
                    }
                }
                else if (service == "color")
                {
                    string type = Console.ReadLine();
                    if (type == "touch up")
                    {
                        sumMoney += 20;
                    }
                    else if (type == "full color")
                    {
                        sumMoney += 30;
                    }
                }
                else if (service == "closed")
                {
                    
                    break;
                }
                
               
            }

            if(sumMoney >= dayTarget)
            {
                Console.WriteLine("You have reached your target for the day!");
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {dayTarget - sumMoney}lv. more.");
            }

            Console.WriteLine($"Earned money: {sumMoney}lv.");

        }
    }
}
