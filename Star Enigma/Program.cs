using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int lanes = int.Parse(Console.ReadLine());
            string pattern = @"[STARstar]";
            string encryption = @"([^\!\@\:\-\.]*)\@(?<planet>[A-Z][a-z]*)([^\!\@\:\-\.]*)\:(?<population>\d+)([^\!\@\:\-\.]*)\!(?<type>[AD])\!([^\!\@\:\-\.]*)->(?<army>\d+)([^\!\@\:\-\.]*)";
            Regex rx = new Regex(pattern);
            List<string> atacked = new List<string>();
            List<string> destroyed = new List<string>();
            for (int i = 0; i < lanes; i++)
            {
                string input = Console.ReadLine();
                MatchCollection mh = rx.Matches(input);
                int encryptKey = mh.Count;
                string encryptedMsg = string.Empty;
                for (int l = 0; l < input.Length; l++)
                {
                    encryptedMsg += (char)(input[l] - encryptKey);
                }
                Regex rgx = new Regex(encryption);
                Match mtch = rgx.Match(encryptedMsg);
                if (mtch.Groups["planet"].Value != string.Empty 
                    && int.Parse(mtch.Groups["population"].Value) > 0
                    && (char.Parse(mtch.Groups["type"].Value) == 'A' || char.Parse(mtch.Groups["type"].Value) == 'D')
                    && int.Parse(mtch.Groups["army"].Value) > 0)
                {
                    string name = mtch.Groups["planet"].Value;
                    int population = int.Parse(mtch.Groups["population"].Value);
                    char ch = char.Parse(mtch.Groups["type"].Value);
                    int armyCount = int.Parse(mtch.Groups["army"].Value);
                    if (ch == 'A')
                    {
                        atacked.Add(name);
                    }
                    else
                    {
                        destroyed.Add(name);
                    }
                }

            }
            Console.WriteLine($"Attacked planets: {atacked.Count}");
            atacked.Sort();
            destroyed.Sort();
            foreach (var item in atacked)
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var item in destroyed)
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
