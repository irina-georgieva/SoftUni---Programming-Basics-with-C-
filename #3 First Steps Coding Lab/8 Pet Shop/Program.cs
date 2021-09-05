using System;

namespace _8_Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int zoodog = int.Parse(Console.ReadLine());
            int dog = int.Parse(Console.ReadLine());
            double result = (zoodog * 2.50) + (dog * 4.0);

            Console.WriteLine(result + " lv.");
        }
    }
}
