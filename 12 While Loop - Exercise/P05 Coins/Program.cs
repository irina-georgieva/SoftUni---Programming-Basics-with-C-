
using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.00 1.00 0.5 0.2 0.1 0.5 0.2 0.1

            double money = double.Parse(Console.ReadLine()) * 100; //3.53 => 353st.
            int counter = 0;

            while (money > 0)
            {
                if (money >= 200)
                {
                    money -= 200;
                    counter++;
                }
                else if (money >= 100)
                {
                    money -= 100;
                    counter++;
                }
                else if (money >= 50)
                {
                    money -= 50;
                    counter++;
                }
                else if (money >= 20)
                {
                    money -= 20;
                    counter++;
                }
                else if (money >= 10)
                {
                    money -= 10;
                    counter++;
                }
                else if (money >= 5)
                {
                    money -= 5;
                    counter++;
                }
                else if (money >= 2)
                {
                    money -= 2;
                    counter++;
                }
                else if (money >= 1)
                {
                    money -= 1;
                    counter++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(counter);
        }
    }
}