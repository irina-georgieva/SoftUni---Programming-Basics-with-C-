using System;

namespace P06
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double sumel = 0;
            double water = 20;
            double sumwater = 0;
            double internet = 15;
            double suminternet = 0;
            double others = 0;
            double sumothers = 0;
            

            for (int i = 1; i <= months ; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                double sum = electricity + water + internet;
                sumel += electricity;
                
                sumwater += water;
                suminternet += internet;
                
                others = sum + sum * 0.2;
                sumothers += others;                
            }

            double costs = sumel + sumwater + suminternet + sumothers;

            Console.WriteLine($"Electricity: {sumel:F2} lv");
            Console.WriteLine($"Water: {sumwater:F2} lv");
            Console.WriteLine($"Internet: {suminternet:F2} lv");
            Console.WriteLine($"Other: {sumothers:F2} lv");
            Console.WriteLine($"Average: {costs / months:F2} lv");
        }
    }
}
