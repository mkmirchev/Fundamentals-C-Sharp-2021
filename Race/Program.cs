using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"[^\W\d]";
            string digitsPattern = @"\d";
            string[] racers = Console.ReadLine().Split(", ").ToArray();
            Dictionary<string, int> personDistance = new Dictionary<string, int>();
            foreach (var item in racers)
            {
                personDistance.Add(item, 0);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    Dictionary<string, int> dct = personDistance.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,z=>z.Value);
                    List<string> str = new List<string>();
                    int count = 0;
                    foreach (var item in dct)
                    {
                        if (count<3)
                        {
                            str.Add(item.Key);
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine("1st place: {0}",str[0]);
                    Console.WriteLine("2nd place: {0}",str[1]);
                    Console.WriteLine("3rd place: {0}",str[2]);
                    break;
                }
                MatchCollection mc = Regex.Matches(input, namePattern);
                string name = string.Join("", mc);
                if (personDistance.ContainsKey(name))
                {
                    MatchCollection mcTwo = Regex.Matches(input, digitsPattern);
                    foreach (var itm in mcTwo)
                    {
                        personDistance[name] += int.Parse(itm.ToString());
                    }
                }
            }
        }
    }
}
