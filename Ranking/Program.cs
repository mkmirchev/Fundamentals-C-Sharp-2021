using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> courseAndPass = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(':').ToArray();
                if (input[0] == "end of contests")
                {
                    break;
                }
                courseAndPass.Add(input[0], input[1]);
            }
            Dictionary<string, Dictionary<string,int>> nameDictCoursePts = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split("=>").ToArray();
                if (input[0] == "end of submissions") // exit loop condition
                {
                    break;
                }
                if (courseAndPass.ContainsKey(input[0]) && courseAndPass[input[0]] == input[1]) //check if course exist and password is correct
                {
                    if (!nameDictCoursePts.ContainsKey(input[2]))
                    {
                        nameDictCoursePts.Add(input[2], new Dictionary<string, int> { { input[0], int.Parse(input[3]) } });
                    }
                    else if (nameDictCoursePts.ContainsKey(input[2]) && !nameDictCoursePts[input[2]].ContainsKey(input[0]))
                    {
                        nameDictCoursePts[input[2]].Add(input[0], int.Parse(input[3]));
                    }
                    else if (int.Parse(input[3]) > nameDictCoursePts[input[2]][input[0]])
                    {
                        nameDictCoursePts[input[2]][input[0]] = int.Parse(input[3]);
                    }
                }
            }
            Dictionary<string,int> output = FindBestCandidate(nameDictCoursePts);
            Console.WriteLine("Best candidate is {0} with total {1} points.", output.Keys.First(), output.Values.First());
            Console.WriteLine("Ranking:");
            foreach (var name in nameDictCoursePts.OrderBy(x=>x.Key))
            {
                Console.WriteLine(name.Key);
                foreach (var item in name.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }

        static Dictionary<string, int> FindBestCandidate(Dictionary<string, Dictionary<string, int>> nameDictCoursePts)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            int sum = int.MinValue;
            string name = string.Empty;
            foreach (var person in nameDictCoursePts)
            {
                int currentSum = 0;
                foreach (var course in person.Value)
                {
                    currentSum += course.Value;
                }
                if (currentSum > sum)
                {
                    sum = currentSum;
                    name = person.Key;
                }
            }
            output.Add(name, sum);
            return output;
        }
    }
}
