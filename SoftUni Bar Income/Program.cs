using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<name>[[A-Z][a-z]{2,})\%[^\.\%\&\*]*\<(?<product>[A-Z][a-z]{2,})\>[^\.\%\&\*]*\|(?<quantity>\d+)\|[^\.\%\&\*0-9]*(?=[0-9])(?<price>\d+(?=.+)\.\d{1,2}(?=\$)|\d+(?=\$))\$";
            decimal income = 0;
            Regex rx = new Regex(pattern);
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    Console.WriteLine($"Total income: {income:F2}");
                    break;
                }
                string name = string.Empty;
                string product = string.Empty;
                int quantity = 0;
                decimal price = 0;  
                Match mtch = rx.Match(input);
                if (mtch.Groups["name"].Value != string.Empty &&
                    mtch.Groups["product"].Value != string.Empty &&
                    int.Parse(mtch.Groups["quantity"].Value) > 0 &&
                    decimal.Parse(mtch.Groups["price"].Value) >0)
                {
                    name = mtch.Groups["name"].Value;
                    product = mtch.Groups["product"].Value;
                    quantity = int.Parse(mtch.Groups["quantity"].Value);
                    price = decimal.Parse(mtch.Groups["price"].Value);
                    Console.WriteLine($"{name}: {product} - { price * quantity:F2}");
                    income += price * quantity;
                }
                
            }
        }   

    }
}
