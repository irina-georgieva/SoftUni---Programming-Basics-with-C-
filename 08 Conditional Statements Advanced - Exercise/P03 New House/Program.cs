using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceflower = 0.0;
            //bool flowerisvalid = true;

            //switch (flower)
            //{
            //    case "Roses":
            //        priceflower = 5.0;
            //        break;
            //    case "Dahlias":
            //        priceflower = 3.80;
            //        break;
            //    case "Tulips":
            //        priceflower = 2.80;
            //        break;
            //    case "Narcissus":
            //        priceflower = 3.0;
            //        break;
            //    case "Gladiolus":
            //        priceflower = 2.50;
            //        break;
            //    default:
            //        flowerisvalid = false;
            //        break;
            //}

            if (flower == "Roses")
            { priceflower = 5; }
            else if (flower == "Dahlias" )
            { priceflower = 3.8; }
            else if (flower == "Tulips")
            { priceflower = 2.8; }
            else if (flower == "Narcissus")
            { priceflower = 3; }
            else if (flower == "Gladiolus")
            { priceflower = 2.5; }

            double price = num * priceflower;

            if (flower == "Roses" && num > 80)
            {
                price -= price * 0.1;
            }

            else if (flower == "Dahlias" && num > 90)
            {
                price -= price * 0.15;
            }

            else if (flower == "Tulips" && num > 80)
            {
                price -= price * 0.15;
            }

            else if (flower == "Narcissus" && num < 120)
            {
                price += price * 0.15;
            }

            else if (flower == "Gladiolus" && num < 80)
            {
                price += price * 0.20;
            }
            

            

            double difference = budget - price;
            //if (flowerisvalid)
           // {
                if (difference >= 0)
                {
                    Console.WriteLine($"Hey, you have a great garden with {num} {flower} and {difference:F2} leva left.");
                }

                else
                {
                    difference = Math.Abs(difference);
                    Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                }

           // }
        }
    }
}
