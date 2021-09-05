using System;

namespace P07
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int seats = int.Parse(Console.ReadLine());
            string ticket = Console.ReadLine();
            int countstudent = 0;
            int allcountstudent = 0;

            int countstandard = 0;
            int allcountstandard = 0;

            int countkid = 0;
            int allcountkid = 0;

            int alltickets = 0;

            while (film != "Finish")
            {
                while (ticket != "End")
                {
                    int movieseats = seats;
                    if(movieseats == 0)
                    {
                        break;
                    }
                    if (ticket == "student")
                    {
                        countstudent++;
                        movieseats--;
                    }
                    else if (ticket == "standard")
                    {
                        countstandard++;
                        movieseats--;
                    }
                    else if (ticket == "kid")
                    {
                        countkid++;
                        movieseats--;
                    }

                    else
                    {
                        break;
                    }                    
                    
                    ticket = Console.ReadLine();
                }

                int count = countstudent + countstandard + countkid;
                Console.WriteLine($"{film} - {1.0*count/seats*100:F2}% full.");

                allcountstudent += countstudent;
                allcountstandard += countstandard;
                allcountkid += countkid;
                alltickets += count;

                countstudent = 0;
                countstandard = 0;
                countkid = 0;

                if (ticket == "Finish")
                {
                    break;
                }

                film = Console.ReadLine();
                seats = int.Parse(Console.ReadLine());
                ticket = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {alltickets}");
            Console.WriteLine($"{1.0*allcountstudent/alltickets*100:F2}% student tickets.");
            Console.WriteLine($"{1.0*allcountstandard/alltickets*100:F2}% standard tickets.");
            Console.WriteLine($"{1.0*allcountkid/alltickets*100:F2}% kids tickets.");
        }
    }
}
