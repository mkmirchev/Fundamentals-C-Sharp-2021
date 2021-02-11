using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double output = GetFactorial(a) / GetFactorial(b);
            Console.WriteLine($"{output:F2}");
        }

        static double GetFactorial(int a)
        {
            double output=1;
            for (int i = 1; i <= a; i++)
            {
                output *= i;
            }
            return output;
        }
    }
}
