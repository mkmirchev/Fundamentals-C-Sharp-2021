using System;
using System.Collections.Generic;

namespace BinaryDigitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bit = int.Parse(Console.ReadLine());
            List<int> lst = new List<int>();

            while (true)
            {
                if (number / 2 > 0 && number % 2 == 0)
                {
                    lst.Add(0);
                    number /= 2;
                }
                else if(number / 2 > 0 && number % 2 == 1)
                {
                    lst.Add(1);
                    number /= 2;
                }
                if (number == 0)
                {
                    break;
                }
                else if (number == 1)
                {
                    lst.Add(1);
                    break;
                }
            }
            lst.Reverse();
            int sum = 0;
            foreach (var item in lst)
            {
                if (item == bit)
                {
                    sum += 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
