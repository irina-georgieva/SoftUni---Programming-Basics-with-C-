﻿using System;

namespace P08
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int ticketprice = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {

                ticketprice = 12;
            }

            else if (day == "Wednesday" || day == "Thursday")
            {
                ticketprice = 14;
            }

            else if(day == "Sunday" || day == "Saturday")
            {
                ticketprice = 16;

            }
            Console.WriteLine(ticketprice);
        }
    }
}
