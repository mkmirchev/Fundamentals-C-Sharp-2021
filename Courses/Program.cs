using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ").ToArray();
                //declaring end condition
                if (input[0] == "end")
                {
                    break;
                }
                if (!courses.ContainsKey(input[0]))
                {
                    courses.Add(input[0], new List<string>{ input[1]});
                }
                else if (courses.ContainsKey(input[0]))
                {
                    courses[input[0]].Add(input[1]);
                }
            }
            foreach (var item in courses.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value.OrderBy(z=>z))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
