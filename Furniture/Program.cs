using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furn>\w+)<<(?<price>\d+.\d{2}|\d+)!(?<quantity>\d+)";
            List<string> lst = new List<string>();
            decimal moneySpent = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")//exit condition
                {
                    Console.WriteLine("Bought furniture:");
                    foreach (var item in lst)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine($"Total money spend: {moneySpent:F2}");
                    break;
                }
                else
                {
                    if (Regex.IsMatch(input, pattern))
                    {
                        Match mtch = Regex.Match(input, pattern);
                        string furn = mtch.Groups["furn"].Value;
                        string price = mtch.Groups["price"].Value;
                        string quantity = mtch.Groups["quantity"].Value;
                        moneySpent += int.Parse(quantity) * decimal.Parse(price);
                        lst.Add(furn);
                    }                   
                }
               
            }
        }
    }
}
