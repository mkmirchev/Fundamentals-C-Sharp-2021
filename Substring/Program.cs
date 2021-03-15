using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string sub = Console.ReadLine().ToLower();
            string str = Console.ReadLine();
            while (str.Contains(sub))
            {
                int a = str.IndexOf(sub);
                str = str.Remove(a, sub.Length);
            }
            Console.WriteLine(str);
        }
    }
}
