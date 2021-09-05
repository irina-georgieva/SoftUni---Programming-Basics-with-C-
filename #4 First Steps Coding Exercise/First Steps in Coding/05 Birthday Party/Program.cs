using System;

namespace _05_Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cake = rent * 20 / 100;
            double drinks = cake - cake * 45 / 100;
            double animator = rent / 3;

            Console.WriteLine(rent + cake + drinks + animator);

        }
    }
}
