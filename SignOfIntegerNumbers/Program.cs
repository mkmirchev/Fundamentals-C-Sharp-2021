using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(IntSign(input));
        }

        static string IntSign(int a)
        {
            string output = string.Empty;
            if (a > 0)
            {
                output = "The number "+ a +" is positive.";
            }
            else if (a < 0)
            {
                output = "The number " + a + " is negative."; ;
            }
            else
            {
                output = "The number 0 is zero.";
            }
            return output;
        }
    }
}
