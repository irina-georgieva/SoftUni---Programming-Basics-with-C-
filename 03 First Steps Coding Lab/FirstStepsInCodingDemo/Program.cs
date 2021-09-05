using System;

namespace FirstStepsInCodingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            double sqm = double.Parse(Console.ReadLine());
            double price = (sqm * 7.61);
            double red = (price * 0.18);
            double result = (price - red);

            Console.WriteLine($"The final price is: {result} lv.");
            Console.WriteLine($"The discount is: {red} lv.");

        }
    }
}
