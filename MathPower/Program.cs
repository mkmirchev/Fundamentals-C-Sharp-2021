using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(a, b)); 
        }
        static double RaiseToPower(double a, int b)
        {
            double output = a;
            for (int i = 1; i < b; i++)
            {
                output *= a;
            }
            return output;
        }
    }
}
