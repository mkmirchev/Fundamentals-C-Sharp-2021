using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(MathOperation(a,operand,b));
        }

        static int MathOperation(int a, char ch, int b)
        {
            int output = 0;
            switch (ch)
            {
                case '+':
                    output = a + b;
                    break;
                case '-':
                    output = a - b;
                    break;
                case '*':
                    output = a * b;
                    break;
                case '/':
                    output = a / b;
                    break;
                default:
                    break;
            }
            return output;
        }
    }
}
