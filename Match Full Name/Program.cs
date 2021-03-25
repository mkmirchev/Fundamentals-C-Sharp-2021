using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string names = Console.ReadLine();
            MatchCollection matches = Regex.Matches(names, regex);
            foreach (Match item in matches)
            {
                Console.Write($"{item.Value} ");
            }
            Console.WriteLine();
        }
    }
}
