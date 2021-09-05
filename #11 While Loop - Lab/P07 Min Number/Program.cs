using System;

namespace P06
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int n = int.Parse(input);

                if (n < min)
                {
                    min = n;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(min);


        }
    }
}
