using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace Nether_realms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            names.Sort();
            string dmgPattern = @"(\d+\.\d+|\-\d+\.\d+)|(\d+|\-\d+)";
            string hpPattern = @"[A-Za-z]";     
            Dictionary<string, decimal[]> dmn = new Dictionary<string, decimal[]>(); //<name,[hp,dmg]>
            foreach (var item in names)
            {
                Regex rx = new Regex(hpPattern);
                dmn.Add(item, new decimal[2]);
                int hp = 0;
                decimal dmg = 0;
                MatchCollection mtchCollection = rx.Matches(item);
                foreach (Match ch in mtchCollection)
                {
                    hp += char.Parse(ch.Value);
                }
                rx = new Regex(dmgPattern);
                MatchCollection mtch = rx.Matches(item);
                foreach (Match dgt in mtch)
                {
                    dmg += decimal.Parse(dgt.Value);
                }
                foreach (char ch in item)
                {
                    if (ch == '*')
                    {
                        dmg *= 2;
                    }
                    else if (ch == '/')
                    {
                        dmg /= 2;
                    }
                }
                dmn[item][0] = hp;
                dmn[item][1] = dmg;
            }
            foreach (var item in dmn)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]:F0} health, {item.Value[1]:F2} damage");
            }
        }
    }
}
