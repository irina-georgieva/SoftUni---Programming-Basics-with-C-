using System;

namespace P06
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int n = int.Parse(input);               
                
                    if(n>max)
                    {
                        max = n;
                    }
                
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
            

        }
    }
}
