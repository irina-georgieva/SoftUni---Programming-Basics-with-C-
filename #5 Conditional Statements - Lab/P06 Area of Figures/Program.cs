using System;

namespace P06
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureName = Console.ReadLine();
            double area = 0.0;

            if(figureName == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if(figureName == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                area = length * width;
            }
            else if(figureName == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if(figureName == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = (side * height) / 2;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
