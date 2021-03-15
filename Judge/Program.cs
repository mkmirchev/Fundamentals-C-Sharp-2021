using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            // {username}->{contest}->{points} 
            Dictionary<string, List<Person>> courseNamePts = new Dictionary<string, List<Person>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                if (input[0] == "no more time")
                {
                    break;
                }
                if (!courseNamePts.ContainsKey(input[1]))
                {
                    Person crs = new Person(input[0], int.Parse(input[2]));
                    courseNamePts.Add(input[1], new List<Person> { crs });
                }
                else if (!courseNamePts[input[1]].Select(x => x.Name).Contains(input[0]))
                {
                    Person crs = new Person(input[0], int.Parse(input[2]));
                    courseNamePts[input[1]].Add(crs);
                }
                else
                {
                    Person crs = new Person();
                    crs = (Person)courseNamePts.Select(x => x.Key);
                    crs.Pts.Add(int.Parse(input[2]));
                }
            }
            foreach (var item in courseNamePts.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()} participants");
                int count = 1;
                foreach (var person in item.Value.OrderByDescending(x=>x.Points))
                {
                    Console.WriteLine($"{count}. {person.Name} <::> {person.Points}");
                    count++;
                }
            }
            Dictionary<string, int> output = new Dictionary<string, int>();
            foreach (var item in courseNamePts)
            {
                foreach (var prsn in item.Value)
                {
                    if (!output.ContainsKey(prsn.Name))
                    {
                        output.Add(prsn.Name, prsn.totalPts);
                    }
                }
            }
            int cnt = 1;
            Console.WriteLine("Individual standings:");
            foreach (var item in output.OrderBy(x=>x.Value))
            {
                Console.WriteLine($"{cnt}. {item.Key} -> {item.Value}");
                cnt++;
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int Points { get; set; }
            public static int Total = 0;
            public static int MaxPts = 0;
            public static List<int> pts = new List<int>();
            public List<int> Pts = pts;
            public int totalPts = GetTotalPts();
            public Person()
            { 
            
            }
            public Person(string courseName, int points)
            {
                Name = courseName;
                Points = points;
            }

            //public static int GetMaxResult()
            //{
            //    int max = int.MinValue;
            //    for (int i = 0; i < pts.Count; i++)
            //    {
            //        if (max < pts[i])
            //        {
            //            max = pts[i];
            //        }
            //    }
            //    return max;
            //}
            public static int GetTotalPts()
            {
                int sum = 0;
                for (int i = 0; i < pts.Count; i++)
                {
                    sum += pts[i];
                }
                return sum;
            }
        }
    }
}
