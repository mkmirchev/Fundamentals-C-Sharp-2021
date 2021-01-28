using System;

namespace Integerperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 firstValue = Int64.Parse(Console.ReadLine());
            Int64 secondValue = Int64.Parse(Console.ReadLine());
            Int64 thirdValue = Int64.Parse(Console.ReadLine());
            Int64 fourthValue = Int64.Parse(Console.ReadLine());
            Int64 result = (firstValue + secondValue) / thirdValue * fourthValue;
            Console.WriteLine(result);
        }
    }
}
