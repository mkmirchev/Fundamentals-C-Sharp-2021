using System;
using System.Collections.Generic;
using System.Linq;

namespace ListTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                if (command.Contains("end"))
                {
                    Console.WriteLine(string.Join(' ', train));
                    break;
                }
                if (command.Contains("Add"))
                {
                    AddWagon(train, int.Parse(command[1]));
                }
                if (command.Count == 1 )
                {
                    AddPassangers(train, int.Parse(command[0]), wagonCapacity);
                }
            }
        }

        private static List<int> AddWagon(List<int> currentTrain, int newWagPassangers)
        {
            currentTrain.Add(newWagPassangers);
            return currentTrain;
        }

        private static List<int> AddPassangers(List<int> currentTrain, int newPassangers, int wagonCapacity)
        {
            bool arePassGotOnTrain = false;
            for (int i = 0; i < currentTrain.Count; i++)
            {
                if (currentTrain[i] + newPassangers <= wagonCapacity)
                {
                    currentTrain[i] += newPassangers;
                    break;
                }
            }
            return currentTrain;
        }
    }
}
