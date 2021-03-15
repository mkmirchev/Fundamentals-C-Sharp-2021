using System;
using System.Linq;
using System.Collections.Generic;

namespace Valid_Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            foreach (var word in input)
            {
                if (word.Count() >= 3 && word.Count() <= 16 && IsLegal(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
        public static bool IsLegal(string input)
        {
            bool islegal = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 65 && input[i] <= 90 || input[i] >= 97 && input[i] <= 122 || input[i] == 45 || input[i] == 95)
                {
                    islegal = true;
                }
                else
                {
                    islegal = false;
                    break;
                }

            }
            return islegal;
        }
    }
}
