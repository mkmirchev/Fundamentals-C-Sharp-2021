using System;
using System.Linq;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondPlayerDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int countFirstDeck = firstPlayerDeck.Count;
            int countSecondDeck = secondPlayerDeck.Count;
            while (true)
            {
                if (firstPlayerDeck[0] > secondPlayerDeck[0])
                {
                    firstPlayerDeck.Add(firstPlayerDeck[0]);
                    firstPlayerDeck.Add(secondPlayerDeck[0]);
                    firstPlayerDeck.RemoveAt(0);
                    secondPlayerDeck.RemoveAt(0);
                    countFirstDeck += 1;
                    countSecondDeck -= 1;
                }
                else if (firstPlayerDeck[0] < secondPlayerDeck[0])
                {
                    secondPlayerDeck.Add(secondPlayerDeck[0]);
                    secondPlayerDeck.Add(firstPlayerDeck[0]);
                    secondPlayerDeck.RemoveAt(0);
                    firstPlayerDeck.RemoveAt(0);
                    countFirstDeck -= 1;
                    countSecondDeck += 1;
                }
                else
                {
                    firstPlayerDeck.RemoveAt(0);
                    secondPlayerDeck.RemoveAt(0);
                    countFirstDeck -= 1;
                    countSecondDeck -= 1;
                }
                if (countFirstDeck == 0 || countSecondDeck == 0)
                {
                    break;
                }
            }
            if (firstPlayerDeck.Count !=0)
            {
                int sum = 0;
                for (int i = 0; i < firstPlayerDeck.Count; i++)
                {
                    sum += firstPlayerDeck[i];
                }
                Console.WriteLine("First player wins! Sum: " + sum);
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < secondPlayerDeck.Count; i++)
                {
                    sum += secondPlayerDeck[i];
                }
                Console.WriteLine("Second player wins! Sum: " + sum);
            }
        }
    }
}
