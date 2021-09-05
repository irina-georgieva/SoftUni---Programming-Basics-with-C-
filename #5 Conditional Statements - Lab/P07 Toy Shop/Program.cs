using System;

namespace P07
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.60;
            double doll = 3;
            double bear = 4.10;
            double minion = 8.20;
            double truck = 2;

            double priceex = double.Parse(Console.ReadLine());
            int nrpuzzle = int.Parse(Console.ReadLine());
            int nrdoll = int.Parse(Console.ReadLine());
            int nrbear = int.Parse(Console.ReadLine());
            int nrminion = int.Parse(Console.ReadLine());
            int nrtruck = int.Parse(Console.ReadLine());

            double pricepuzzle = puzzle * nrpuzzle;
            double pricedoll = doll * nrdoll;
            double pricebear = bear * nrbear;
            double priceminion = minion * nrminion;
            double pricetruck = truck * nrtruck;

            int totaltoys = (nrpuzzle + nrdoll + nrbear + nrminion + nrtruck);
            double pricetoys = (pricepuzzle + pricedoll + pricebear + priceminion + pricetruck);

            if (totaltoys >= 50)
            {
                double afterred = pricetoys - (pricetoys * 0.25);
                double afterrent = afterred - (afterred * 0.1);

                if (afterrent >= priceex)
                {
                    double moneyleft = afterrent - priceex;

                    Console.WriteLine("Yes! " + ($"{moneyleft:F2}") + " lv left.");
                }
                else 
                {
                    double moneyleft = priceex - afterrent;

                    Console.WriteLine("Not enough money! " + ($"{moneyleft:F2}") + " lv needed.");
                }
            }
             else
             {
                    double afterrent = pricetoys - (pricetoys * 0.10);

                if (afterrent >= priceex)
                {
                    double moneyleft = afterrent - priceex;

                    Console.WriteLine("Yes! " + ($"{moneyleft:F2}") + " lv left.");
              
                }

                 else 
                 {
                    double moneyleft = priceex - afterrent;

                    Console.WriteLine("Not enough money! " + ($"{moneyleft:F2}") + " lv needed.");
                 }
            }


        }
    }
}
