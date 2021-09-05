using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double ticket = 0.0;
           
            if (projection == "Premiere")
            {
                ticket = 12;
            }
            else if (projection == "Normal")
            {
                ticket = 7.50;
            }
            else if (projection == "Discount")
            {
                ticket = 5;
            }

            int client = a * b;

            Console.WriteLine($"{(client * ticket):F2} leva");

        }
    }
}
