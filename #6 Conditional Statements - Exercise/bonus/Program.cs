using System;

namespace bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            double five = a % 10;
            // 12345 / 10 = 1234.5 ->5
            // 1234 / 10 = 123.4 ->4
            // 123 / 10 = 12.3 ->3
            // 12 / 10 = 1.2 ->2

            int nfour = a / 10;
            // 12345 / 10 = 1234
            // 1234 / 10 = 123
            // 123 / 10 = 12
            // 12 / 10 = 1
            double four = nfour % 10;
            // 1234 / 10 = 123.4 ->4
            // 123 / 10 = 12.3 ->3
            // 12 / 10 = 1.2 ->2
            // 1 / 10 = 0.1 ->1

            int nthree = nfour / 10;
            // 1234 / 10 = 123
            // 123 / 10 = 12
            // 12 / 10 = 1
            double three = nthree % 10;
            // 123 / 10 = 12.3 ->3
            // 12 / 10 = 1.2 ->2
            // 1 / 10 = 0.1 ->1

            int ntwo = nthree / 10;
            // 123 / 10 = 12
            double two = ntwo % 10;
            // 12 / 10 = 1.2 -> 2

            int one = ntwo / 10;
            // 12 / 10 = 1

            if (three == 0)
            {
                Console.WriteLine($"{five}{four}");
            }

            else if (two == 0)
            {
                Console.WriteLine($"{five}{four}{three}");
            }

            else if (one == 0)
            {
                Console.WriteLine($"{five}{four}{three}{two}");
            }

            else
            {
                Console.WriteLine($"{five}{four}{three}{two}{one}");
            }

         // string ostatuk = "";
         //  if (a <=10)
         //  {
         //      Console.WriteLine(ostatuk);
         //  }
         //  else
         //  {
         //      ostatuk += $"{ a % 10}";
         //      a = a / 10;
         //  }
          



        } 
    }
}
