using System;
using System.Collections.Generic;
using System.Linq;

namespace The_pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //reading N lanes
            Dictionary<string, Dictionary<string, string>> collection = new Dictionary<string, Dictionary<string, string>>(); //piece - composer - key
            for (int i = 0; i < n; i++) //reading N lanes
            {
                string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();
                collection.Add(input[0], new Dictionary<string, string> { { input[1], input[2] } }); //piece - composer - key
            }
            while (true)
            {
                string[] commands = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commands[0] == "Stop")
                {
                    foreach (var item in collection.OrderBy(x=>x.Key).ThenBy(x=>x.Value.Select(z=>z.Key)))
                    {
                        foreach (var secondKvp in item.Value)
                        {
                            Console.WriteLine($"{item.Key} -> Composer: {secondKvp.Key}, Key: {secondKvp.Value}");
                        }                     
                    }
                    break;
                }
                if (commands[0] == "Add")
                {
                    if (collection.ContainsKey(commands[1])) //check if piece exist
                    {
                        Console.WriteLine($"{commands[1]} is already in the collection!");
                    }
                    else //if not exist add it to collection
                    {
                        collection.Add(commands[1], new Dictionary<string, string> { { commands[2], commands[3] } });
                        Console.WriteLine($"{commands[1]} by {commands[2]} in {commands[3]} added to the collection!");
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (collection.ContainsKey(commands[1])) //remove piece if exist in collection
                    {
                        collection.Remove(commands[1]);
                        Console.WriteLine($"Successfully removed {commands[1]}!");
                    }
                    else //return msg if piece doesnt exist in collection
                    {
                        Console.WriteLine($"Invalid operation! {commands[1]} does not exist in the collection.");
                    }
                }
                else if (commands[0] == "ChangeKey")
                {
                    if (collection.ContainsKey(commands[1])) //check if piece exist
                    {
                        Dictionary<string, string> dict = collection[commands[1]];
                        collection[commands[1]][dict.First().Key] = commands[2];
                        Console.WriteLine($"Changed the key of {commands[1]} to {commands[2]}!");
                    }
                    else //if not exist in the collection
                    {
                        Console.WriteLine($"Invalid operation! {commands[1]} does not exist in the collection.");
                    }
                }
            }
        }
    }
}
