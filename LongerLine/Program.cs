using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA = double.Parse(Console.ReadLine());
            double yA = double.Parse(Console.ReadLine());
            double xB = double.Parse(Console.ReadLine());
            double yB = double.Parse(Console.ReadLine());
            double xC = double.Parse(Console.ReadLine());
            double yC = double.Parse(Console.ReadLine());
            double xD = double.Parse(Console.ReadLine());
            double yD = double.Parse(Console.ReadLine());
            double firstLenght = FindDistance(Math.Abs(xA - xB), Math.Abs(yA - yB));
            double secondLenght = FindDistance(Math.Abs(xC - xD), Math.Abs(yC - yD));
            if (firstLenght >= secondLenght)
            {
                CloseToStartOfCoordinateSystem(xA, yA, xB, yB);
            }
            else
            {
                CloseToStartOfCoordinateSystem(xC, yC, xD, yD);
            }
        }

        static double FindDistance(double a, double b)
        {
            double c = Math.Sqrt((a * a) + (b * b));
            return c;
        }
        static void CloseToStartOfCoordinateSystem(double a, double b, double c, double d)
        {
            if (FindDistance(a,b) <= FindDistance(c,d))
            {
                Console.WriteLine($"({a}, {b})({c}, {d})");
            }
            else
            {
                Console.WriteLine($"({c}, {d})({a}, {b})");
            }
        }
    }
}
