using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondtArr = Console.ReadLine().Split(' ');
            foreach (var secondArrElement in secondtArr)
            {
                foreach (var firstArrElement in firstArr)
                {
                    if (secondArrElement == firstArrElement)
                    {
                        Console.Write(secondArrElement + " ");
                    }
                }
            }
        }
    }
}
