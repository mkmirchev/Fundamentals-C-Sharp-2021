using System;
using System.Linq;
using System.Collections.Generic;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                if (input.Contains(" | "))
                {
                    string[] temp = input.Split(" | ").ToArray(); //{side}{user}
                    if (!forceBook.ContainsKey(temp[0]))
                    {
                        forceBook.Add(temp[0], new List<string> { temp[1] });
                    }
                    else
                    {
                        if (!forceBook[temp[0]].Contains(temp[1]))
                        {
                            forceBook[temp[0]].Add(temp[1]);
                        }
                    }
                }
                else if (input.Contains(" -> "))
                {
                    string[] temp = input.Split(" -> ").ToArray(); //{user}{side}
                    bool exist = false;
                    bool sideExist = false;
                    string existingUsersSide = "";
                    foreach (var side in forceBook)
                    {
                        if (side.Value.Contains(temp[0]))
                        {
                            exist = true;
                            existingUsersSide = side.Key;
                            if (temp[1] == side.Key)
                            {
                                sideExist = true;
                            }
                        }
                    }
                    if (exist == true)
                    {
                        forceBook[temp[1]].Add(temp[0]);
                        forceBook[existingUsersSide].Remove(temp[0]);
                        Console.WriteLine($"{temp[0]} joins the {temp[1]} side!");
                    }
                    else 
                    {
                        if (sideExist)
                        {
                            forceBook[temp[1]].Add(temp[0]);
                            Console.WriteLine($"{temp[0]} joins the {temp[1]} side!");
                        }
                        else
                        {
                            forceBook.Add(temp[1], new List<string> { temp[0] });
                            Console.WriteLine($"{temp[0]} joins the {temp[1]} side!");
                        }
                    }
                }
            }
            foreach (var item in forceBook.Where(x=>x.Value.Count > 0)
                                            .OrderByDescending(z=>z.Value.Count)
                                            .ThenBy(s=>s.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var prsn in item.Value.OrderBy(q=>q))
                {
                    Console.WriteLine($"! {prsn}");
                }
            }

        }
    }
}
