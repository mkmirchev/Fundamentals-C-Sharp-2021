using System;
using System.Linq;
using System.Collections.Generic;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(" -> ").ToArray();
                if (inputs[0] == "End")
                {
                    break;
                }
                if (!companies.ContainsKey(inputs[0]))
                {
                    companies.Add(inputs[0], new List<string> { inputs[1] });
                }
                else if (companies.ContainsKey(inputs[0]))
                {
                    if (!companies[inputs[0]].Contains(inputs[1]))
                    {
                        companies[inputs[0]].Add(inputs[1]);
                    }
                }
            }
            foreach (var cmpny in companies.OrderBy(x=>x.Key))
            {
                Console.WriteLine(cmpny.Key);
                foreach (var employee in cmpny.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
