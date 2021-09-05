using System;

namespace _3_Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // преобразувам текста в число
            int squareSide = int.Parse(Console.ReadLine());
            // изчисля лицето на квадрат
            int area = squareSide * squareSide;
            Console.WriteLine(area);
        }
    }
}
