using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> bombData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList(); //first number is the bomb number, second number is bomb power
            List<int> bombPositions = new List<int>();
            int bombNumber = bombData[0];
            int bombPower = bombData[1];


            // finding items  to remove
            List<bool> itemsToRemove = new List<bool>();
            for (int y = 0; y < input.Count; y++)
            {
                itemsToRemove.Add(false);
            }

            for (int k = 0; k < input.Count; k++)
            {
                if (input[k] == bombNumber)
                {
                    for (int z = k-bombPower; z <= k+bombPower; z++)
                    {
                        if (z >= 0 && z < input.Count)
                        { 
                            itemsToRemove[z] = true;
                        }                  
                    }
                }               
            }
            //processing output
            List<int> output = new List<int>();
            for (int a = 0; a < input.Count; a++)
            {
                if (itemsToRemove[a] != true)
                {
                    output.Add(input[a]);
                }
            }
            //generating output
            int sum = 0;
            for (int j = 0; j < output.Count; j++)
            {
                sum += output[j];
            }
            Console.WriteLine(sum);
        }
    }
}
