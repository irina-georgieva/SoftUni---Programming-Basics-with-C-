using System;

namespace P12
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0.0;

            if (city == "Sofia")
            {
                if (sales >=0 && sales <= 500)
                { comission = 0.05; }
                else if (sales >= 500 && sales <= 1000)
                { comission = 0.07; }
                else if (sales >= 1000 && sales <= 10000)
                { comission = 0.08; }
                else if (sales > 10000)
                { comission = 0.12; }
                else
                { Console.WriteLine("error"); }
            }

            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                { comission = 0.045; }
                else if (sales >= 500 && sales <= 1000)
                { comission = 0.075; }
                else if (sales >= 1000 && sales <= 10000)
                { comission = 0.10; }
                else if (sales > 10000)
                { comission = 0.13; }
                else
                { Console.WriteLine("error"); }
            }

            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                { comission = 0.055; }
                else if (sales >= 500 && sales <= 1000)
                { comission = 0.08; }
                else if (sales >= 1000 && sales <= 10000)
                { comission = 0.12; }
                else if (sales > 10000)
                { comission = 0.145; }
                else
                { Console.WriteLine("error"); }
            }

            else
            { Console.WriteLine("error"); }

            double endcommision = comission * sales;

            if (endcommision > 0)
            { Console.WriteLine($"{endcommision:F2}"); }
        }
    }
}
