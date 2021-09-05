using System;

namespace _4_Vacation_book_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesofbook = int.Parse(Console.ReadLine());
            double pagesperhour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double timeforbook = pagesofbook / pagesperhour;
            double hoursperday = timeforbook / days;

            Console.WriteLine(hoursperday);
        }
    }
}
