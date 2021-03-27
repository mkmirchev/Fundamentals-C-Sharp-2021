using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})([-\.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();
            MatchCollection mtch = Regex.Matches(input, pattern);
            foreach (Match item in mtch)
            {
                var date = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {date}, Month: {month}, Year: {year}");
            }
        }
    }
}
