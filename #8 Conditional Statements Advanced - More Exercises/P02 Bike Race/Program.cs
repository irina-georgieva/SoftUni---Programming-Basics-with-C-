using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {         
            int juniors = int.Parse(Console.ReadLine());          
            int seniors = int.Parse(Console.ReadLine());
            string route = Console.ReadLine();

            double feejuniors = 0.0;
            double feeseniors = 0.0;

            switch (route)
            {
                case "trail":
                    feejuniors = 5.50;
                    feeseniors = 7;
                    break;
                case "cross-country":                    
                    feejuniors = 8;                    
                    feeseniors = 9.50;
                    break;
                case "downhill":
                    feejuniors = 12.25;
                    feeseniors = 13.75;
                    break;
                case "road":
                    feejuniors = 20;
                    feeseniors = 21.50;
                    break;
            }

            if (juniors + seniors >= 50 && route == "cross-country")
            {
                feejuniors -= feejuniors * 0.25;
                feeseniors -= feeseniors * 0.25;
            }
           
            double win = (juniors * feejuniors) + (seniors * feeseniors);            
            double cost = 0.05 * win;

            //377.625
            Console.WriteLine($"{Math.Round(win - cost,2):F2}");            
        }
    }
}

