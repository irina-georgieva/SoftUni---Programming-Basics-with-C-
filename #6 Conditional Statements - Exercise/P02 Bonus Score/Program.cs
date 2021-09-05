using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double bonus = 0.0;

                if (n<=100)
            {
                bonus = 5;
            }
                else if (n>1000)
            {
                bonus = n * 0.1;
            }
                else
            {
                bonus = n * 0.2;
            }
            
                if (n % 2 == 0)
            {
                bonus = bonus + 1;
            }
                else if (n % 10 == 5)
            {
                bonus = bonus + 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(bonus + n);
                        
        }
    }
}
