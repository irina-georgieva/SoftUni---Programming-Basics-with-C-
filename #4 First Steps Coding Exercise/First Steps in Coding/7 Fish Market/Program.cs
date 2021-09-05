using System;

namespace _7_Fish_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double qgodi = double.Parse(Console.ReadLine());
            
            double malini = qgodi / 2.0;
            double portokali = malini - malini * 40 / 100;
            double banani = malini - malini * 80 / 100;

            double kgbanani = double.Parse(Console.ReadLine());
            double kgportokali = double.Parse(Console.ReadLine());
            double kgmalini = double.Parse(Console.ReadLine());
            double kgqgodi = double.Parse(Console.ReadLine());

            double price = malini * kgmalini + portokali * kgportokali + banani * kgbanani + qgodi * kgqgodi;

            Console.WriteLine(Math.Round(price, 2));
         



        }
    }
}
