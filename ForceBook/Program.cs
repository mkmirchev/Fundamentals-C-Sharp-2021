using System;
using System.Linq;
using System.Collections.Generic;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "Lumpawaroo")
                {
                    break;
                }
                if (str.Contains(" | "))
                {                 
                    string[] userData = str.Split(" | ");
                    //chekc if userExist
                    if (!users.ContainsKey(userData[1]))
                    {
                        users.Add(userData[1], userData[0]);
                    }
                }
                else if (str.Contains(" -> "))
                {
                    string[] userData = str.Split(" -> ");
                    if (users.ContainsKey(userData[0]))
                    {
                        users[userData[0]] = userData[1];
                        Console.WriteLine($"{userData[0]} joins the {userData[1]} side!");
                    }
                    else if (!users.ContainsKey(userData[0]))
                    {
                        users.Add(userData[0], userData[1]);
                        Console.WriteLine($"{userData[0]} joins the {userData[1]} side!");
                    }
                }
            }
            foreach (var item in users
                .GroupBy(x=>x.Value)
                .OrderByDescending(x=>x.Count())
                .ThenBy(x=>x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Count()}");
                foreach (var prsn in item.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"! {prsn.Key}");
                }
            }
        }
    }
}
