using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA = double.Parse(Console.ReadLine());
            double yA = double.Parse(Console.ReadLine());
            double xB = double.Parse(Console.ReadLine());
            double yB = double.Parse(Console.ReadLine());
            double cA = FindDistance(xA, yA);
            double cB = FindDistance(xB, yB);
            if (cA > cB)
            {
                Console.WriteLine($"({xB}, {yB})");
            }
            else if (cA <= cB)
            {
                Console.WriteLine($"({xA}, {yA})");
            }
        }

        static double FindDistance(double a, double b) 
        {
            double c = Math.Sqrt((a * a) + (b * b));
            return c;
        }
    }
}
