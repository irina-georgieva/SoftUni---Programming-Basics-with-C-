using System;

namespace P10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumchetni = 0;
            int sumnechetni = 0;

            for (int i = 1; i <= n; i++)
            {
                
                if (i % 2 == 0)
                {
                    sumchetni += int.Parse(Console.ReadLine());
                }

                else
                {
                    sumnechetni += int.Parse(Console.ReadLine());
                }
            }

            if (sumchetni == sumnechetni)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumchetni}");

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumchetni - sumnechetni)}");

            }




        }
    }
}
