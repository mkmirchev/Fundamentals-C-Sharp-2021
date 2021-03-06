using System;
using System.Linq;
using System.Collections.Generic;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int> { { "shards", 0 }, { "fragments", 0 }, { "motes", 0 } };
            Dictionary<string, int> junks = new Dictionary<string, int>();
            bool isObtained = false;
            while (isObtained == false)
            {
                List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToList();
               
                for (int i = 0; i < input.Count; i+=2)
                {
                    if (isObtained == true) //escape from loop if item is obtained
                    {
                        break;
                    }
                    else //add materials and junks
                    {
                        if (materials.ContainsKey(input[i+1]))
                        {
                            materials[input[i + 1]] += int.Parse(input[i]);

                            //check if any item is obtained and reduce materials with the price of item
                            if (materials[input[i + 1]] >= 250)
                            {
                                materials[input[i + 1]] -= 250;
                                isObtained = true;
                                switch (input[i+1])
                                {
                                    case "shards":
                                        Console.WriteLine("Shadowmourne obtained!");
                                        break;
                                    case "fragments":
                                        Console.WriteLine("Valanyr obtained!");
                                        break;
                                    case "motes":
                                        Console.WriteLine("Dragonwrath obtained!");
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        else if (junks.ContainsKey(input[i + 1]))
                        {
                            junks[input[i + 1]] += int.Parse(input[i]);
                        }
                        else
                        {
                            junks.Add(input[i + 1], int.Parse(input[i]));
                        }
                    }

                }
            }
            foreach (var item in materials.OrderByDescending(z=>z.Value).ThenBy(y=>y.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junks.OrderBy(s=>s.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
