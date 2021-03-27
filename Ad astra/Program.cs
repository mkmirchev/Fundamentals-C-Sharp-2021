using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Ad_astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternOne = @"\|[A-Za-z\s]+\|\d{2}\/\d{2}\/\d{2}\|?(\d{1}|\d{2}|\d{3}|\d{4}|\d{5})\||#[A-Za-z\s]+#\d{2}\/\d{2}\/\d{2}#?(\d{1}|\d{2}|\d{3}|\d{4}|\d{5})#";
            string input = Console.ReadLine();
            Regex rx = new Regex(patternOne);
            MatchCollection mtch = Regex.Matches(input, patternOne);
            List<string[]> lst = new List<string[]>();
            foreach (var item in mtch)
            {

                if (item.ToString().Contains('#'))
                {
                    lst.Add(item.ToString().Split('#', StringSplitOptions.RemoveEmptyEntries).ToArray());
                }
                else
                {
                    lst.Add(item.ToString().Split('|',StringSplitOptions.RemoveEmptyEntries).ToArray());
                }
            }
            int totalCalories = 0;
            foreach (var item in lst)
            {
               totalCalories += int.Parse(item[2]);
            }
            //output
            Console.WriteLine($"You have food to last you for: {totalCalories/2000:F0} days!");
            foreach (var item in lst)
            {
                Console.WriteLine($"Item: {item[0]}, Best before: {item[1]}, Nutrition: {item[2]}");
            }
        }
    }
}
