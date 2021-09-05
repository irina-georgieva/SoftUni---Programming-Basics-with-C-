using System;

namespace P07_new
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalTicketsCount = 0;
            int studentsTickets = 0;
            int standardTickets = 0;
            int kidsTickets = 0;
            int currentMovieTickets = 0;

            while(movie != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                for (int i = 0; i < seats; i++)
                {
                    string ticketType = Console.ReadLine();

                    if(ticketType == "End")
                    {
                        break;
                    }

                    currentMovieTickets++;
                    totalTicketsCount++;

                    switch(ticketType)
                    {
                        case "student":
                            studentsTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidsTickets++;
                            break;
                    }
                }

                Console.WriteLine($"{movie} - {(double)(currentMovieTickets / (double)seats) * 100:F2}% full.");
                currentMovieTickets = 0;

                movie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{1.0 * studentsTickets / totalTicketsCount * 100:F2}% student tickets.");
            Console.WriteLine($"{1.0 * standardTickets / totalTicketsCount * 100:F2}% standard tickets.");
            Console.WriteLine($"{1.0 * kidsTickets / totalTicketsCount * 100:F2}% kids tickets.");
        }
    }
}
