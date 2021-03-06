using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders___associative_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> shopItems = new Dictionary<string, double[]>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0]=="buy")
                {
                    break;
                }
                else
                {
                    if (!shopItems.ContainsKey(input[0]))
                    {
                        shopItems.Add(input[0], new double[] { double.Parse(input[1]), double.Parse(input[2]) });
                    }
                    else
                    {
                        if (shopItems[input[0]][0] == double.Parse(input[1]))
                        {
                            shopItems[input[0]][1] += double.Parse(input[2]);
                        }
                        else
                        {
                            shopItems[input[0]][1] += double.Parse(input[2]);
                            shopItems[input[0]][0] = double.Parse(input[1]);
                        }
                    }
                }
            }
            foreach (var item in shopItems)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0]*item.Value[1]):F2}");
            }
        }
    }
}
