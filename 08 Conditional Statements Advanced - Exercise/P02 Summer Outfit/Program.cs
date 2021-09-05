using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            string timeofday = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (timeofday == "Morning")
            {
                if (time <= 18)
                             
                {
                    outfit ="Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (time <=24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time >=25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }                
                
            }
                

            else if (timeofday == "Afternoon")
            {
                if (time <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }

            else if (timeofday == "Evening")
            {
                if (time <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {time} degrees, get your {outfit} and {shoes}.");


        }
    }
}
