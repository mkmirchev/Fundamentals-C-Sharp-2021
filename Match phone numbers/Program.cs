using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_phone_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359-2-\d{3}-\d{4}\b)|(\+359 2 \d{3} \d{4}\b)";
            string input = Console.ReadLine();
            MatchCollection mtch = Regex.Matches(input, pattern);
            string[] strArr = mtch.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", strArr));
        }
    }
}
