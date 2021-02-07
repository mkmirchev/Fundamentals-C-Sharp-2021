using System;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string activity = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Calculation(activity, a, b);
        }
        static void Calculation(string activity, int a, int b)
        {
            if (activity == "add")
            {
                Console.WriteLine(a+b);
            }
            else if (activity == "multiply")
            {
                Console.WriteLine(a * b);
            }
            else if (activity == "substract")
            {
                Console.WriteLine(a - b);
            }
            else if (activity == "divide")
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
