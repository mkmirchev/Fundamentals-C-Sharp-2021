using System;
using System.Collections.Generic;

namespace Tribunacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            TribunaciNumbers(a);
        }

        static void TribunaciNumbers(int a)
        {
            List<int> lst = new List<int> { 1, 1, 2 };
            if (a==1)
            {
                Console.WriteLine(1);
               return;
            }
            else if (a == 2)
            {
                Console.WriteLine(1 + " " + 1);
                return;
            }
            else if (a == 3)
            {
                Console.WriteLine(1 + " " + 1 + " " + 2);
                return;
            }
            else if (a > 3)
            {
                for (int i = 2; i < a - 1; i++)
                {
                    lst.Add(lst[i] + lst[i - 1] + lst[i - 2]);
                }
                Console.WriteLine(string.Join(" ",lst));
            }
        }
    }
}
