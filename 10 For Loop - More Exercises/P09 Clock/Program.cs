using System;

namespace P09
{
    class Program
    {
        static void Main(string[] args)
        {

            int hour = -1;
            int minute = 0;

           for (int i = 0; i < 1440; i++)
           {
               if (i % 60 == 0)
               {
                   hour++;
               }
               minute = i % 60;
               Console.WriteLine($"{hour} : { minute}");
               
           }
        }
    }
}
