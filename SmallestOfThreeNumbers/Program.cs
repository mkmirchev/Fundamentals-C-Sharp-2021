using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            SmallestFromThree(a, b, c);
        }

        static void SmallestFromThree(int a, int b, int c)
        {
            int smallest = int.MaxValue;
            if (a>=b)
            {
               
                if (b>=c)
                {
                    smallest = c;
                }
                else
                {
                    smallest = b;
                }
            }
            else if (b>=a)
            {
               
                if (a>=c)
                {
                    smallest = c;
                }
                else
                {
                    smallest = a;
                }
            }

            Console.WriteLine(smallest);
        
        }
    }
}
