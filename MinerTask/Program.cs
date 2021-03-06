using System;
using System.Linq;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> goods = new Dictionary<string, int>();
            while (true)
            {
                string ore = Console.ReadLine();
                if (ore == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (!goods.ContainsKey(ore))
                {
                    goods.Add(ore, quantity);
                }
                else
                {
                    goods[ore] += quantity;
                }
            }
            foreach (var ore in goods)
            {
                Console.WriteLine($"{ore.Key} -> {ore.Value}");
            }
        }
    }
}
