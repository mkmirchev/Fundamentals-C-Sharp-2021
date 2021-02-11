using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int output = SubTwoNumbers(SumTwoNumbers(a,b),c);
            Console.WriteLine(output);
        }

        static int SumTwoNumbers(int a, int b)
        {
            int output = a + b;
            return output;
        }
        static int SubTwoNumbers(int a,int b)
        {
            int output = a - b;
            return output;
        }
    }
}
