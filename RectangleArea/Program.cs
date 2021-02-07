using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(RectangleAreaCalc(a,b));
        }
        static double RectangleAreaCalc(double a, double b)
        {
            double area = 0;
            area = a * b;
            return area;
        }
    }
}
