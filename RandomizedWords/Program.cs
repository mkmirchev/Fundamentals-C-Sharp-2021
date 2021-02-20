using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Random rnd = new Random();
            for (int i = 0; i < strList.Count; i++)
            {
                int a = rnd.Next(0,strList.Count);
                string temp = strList[i];
                strList[i] = strList[a];
                strList[a] = temp;
            }
            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
