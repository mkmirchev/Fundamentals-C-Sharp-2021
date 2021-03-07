using System;
using System.Collections.Generic;
using System.Linq;

namespace Softuni_exam_result
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pplCourse = new Dictionary<string, List<string>>();
            Dictionary<string, int> pplPts = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split('-');
                if (input[0] == "exam finished")
                {
                    break;
                }
                if (input[1] == "banned")
                {
                    pplCourse[input[0]].Add(input[1]);
                    pplPts.Add(input[0], -1);
                }
                else
                {
                    if (!pplCourse.ContainsKey(input[0]))
                    {
                        pplCourse.Add(input[0], new List<string> { input[1] });
                        pplPts.Add(input[0], int.Parse(input[2]));
                    }
                    else if (pplCourse[input[0]].Contains(input[1]) && int.Parse(input[2]) > pplPts[input[0]])
                    {
                        pplPts[input[0]] = int.Parse(input[2]);
                    }
                    else
                    {
                        pplCourse[input[0]].Add(input[1]);
                        if (int.Parse(input[2]) > pplPts[input[0]])
                        {
                            pplPts.Add(input[0], int.Parse(input[2]));
                        }
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var item in pplPts.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                if (!(item.Value == -1))
                {
                    Console.WriteLine($"{item.Key} | {item.Value}");
                }    
            }
            Console.WriteLine("Submissions:");
            List<string> printed = new List<string>();
            foreach (var item in pplCourse)
            {
                int count = 0;
                foreach (var course in item.Value)
                {
                    if (!printed.Contains(course) && count == 0)
                    {
                        printed.Add(course);
                        count++;
                    }
                    else
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{item.Value} {count}");
            }
        }
    }
}
