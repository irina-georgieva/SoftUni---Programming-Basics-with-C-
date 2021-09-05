using System;

namespace P06
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double cake = width * length;

            string input = Console.ReadLine();
            int piecesum = 0;

            while(input != "STOP")
            {
                int piece = int.Parse(input);
                piecesum += piece;

                if(piecesum >= cake)
                {
                    Console.WriteLine($"No more cake left! You need {piecesum - cake} pieces more.");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "STOP")
            {
                Console.WriteLine($"{cake - piecesum} pieces are left.");
            }
        }
    }
}
