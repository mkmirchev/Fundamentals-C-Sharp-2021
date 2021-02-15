using System;
using System.Linq;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int reads = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < reads; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[2] != "not" && guests.Contains(input[0]) == false)
                {
                    guests.Add(input[0]);
                }
                else if(input[2] != "not" && guests.Contains(input[0]) == true)
                {
                    Console.WriteLine($"{input[0]} is already in the list!");
                }
                if (input[2] == "not" && guests.Contains(input[0]) == false)
                {
                    Console.WriteLine($"{input[0]} is not in the list!");
                }
                else if (input[2] == "not" && guests.Contains(input[0]) == true)
                {
                    guests.Remove(input[0]);
                }
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
