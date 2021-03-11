using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            // {username}->{contest}->{points}
            Dictionary<string, Dictionary<string, int>> usernameContestPoints = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                if (input[0] == "no more time")
                {
                    break;
                }

            }
        }
    }
}
