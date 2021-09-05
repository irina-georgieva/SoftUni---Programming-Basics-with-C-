using System;

namespace P06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool found = true;

            for (int i = 1111; i <= 9999; i++)
            {
                string currentNum = i.ToString();

                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (currentDigit != 0 && n % currentDigit == 0)
                    {
                        continue;
                    }
                    else
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    Console.Write(i + " ");
                }

                found = true;
            }
        }
    }
}
