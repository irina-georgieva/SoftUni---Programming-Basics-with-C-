using System;

namespace P06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0.0;            
            string type = "";
            double proverka = 0.0;

            if (operation == "+")
            {
                result = N1 + N2;
                proverka = result % 2;
                if (proverka == 0)
                { type = "even"; }
                else
                { type = "odd"; }
            }

            else if (operation == "-")
            {
                result = N1 - N2;
                proverka = result % 2;
                if (proverka == 0)
                { type = "even"; }
                else
                { type = "odd"; }
            }

            else if (operation == "*")
            {
                result = N1 * N2;
                proverka = result % 2;
                if (proverka == 0)
                { type = "even"; }
                else
                { type = "odd"; }
            }

            else if (operation == "/" && N2 !=0 )
            {
                result = (N1 * 1.0) / N2;
            }

            else if (operation == "%" && N2 != 0)
            {
                result = N1 % N2;
            }

            if (operation == "/" && N2 !=0)
            { Console.WriteLine($"{N1} {operation} {N2} = {result:F2}"); }
            else if (operation == "%" && N2 !=0)
            { Console.WriteLine($"{N1} {operation} {N2} = {result}"); }
            else if (operation == "%" && N2 == 0)
            { Console.WriteLine($"Cannot divide {N1} by zero"); }
            else if (operation == "/" && N2 == 0)
            { Console.WriteLine($"Cannot divide {N1} by zero"); }
            else
             Console.WriteLine($"{N1} {operation} {N2} = {result} - {type}");
            
        }

            
    }
}
