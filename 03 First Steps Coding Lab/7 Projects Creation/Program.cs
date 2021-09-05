using System;

namespace _7_Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            Cstring archname = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hours = projects * 3;


            string result = $"The architect {archname} will need {hours} hours to complete {projects} project/s.";
            Console.WriteLine(result);
        }
    }
}
