using System;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kmFirst = double.Parse(Console.ReadLine());

            double sumkm = kmFirst;

            for (int i = 1; i <= days; i++)
            {            
                int percent = int.Parse(Console.ReadLine());
                double kmNew = kmFirst + kmFirst * (double)percent/100;
                sumkm += kmNew;
                kmFirst = kmNew;                
            }

            if(sumkm >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(sumkm - 1000)} more kilometers!");
            }
            else if (sumkm < 1000)
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - sumkm)} more kilometers");
            }
        }
    }
}
