using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> order = new List<string>(4);
            for (int i = 0; i < n; i++)
            {
                order.Add(Console.ReadLine());
            }
            int count = 1;
            order.Sort();
            foreach (var item in order)
            {
                Console.WriteLine(count + "."+ item);
                count++;
            }
        }
    }
}
