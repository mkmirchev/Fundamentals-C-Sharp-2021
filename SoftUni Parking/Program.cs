using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingDB = new Dictionary<string, string>();
            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "register")
                {
                    if (!parkingDB.ContainsKey(input[1]))
                    {
                        parkingDB.Add(input[1], input[2]);
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                    }
                    else if (parkingDB.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingDB[input[1]]}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (!parkingDB.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                    else if (parkingDB.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} unregistered successfully");
                        parkingDB.Remove(input[1]);
                    }
                }
                
            }
            foreach (var item in parkingDB)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
