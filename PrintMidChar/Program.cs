using System;

namespace PrintMidChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetMidChars(input));
        }


        static string GetMidChars(string a)
        {
            string output = string.Empty;
            if (a.Length % 2 == 0)
            {
                output = a[a.Length / 2 - 1].ToString() + a[a.Length / 2].ToString();
            }
            else
            {
                output = a[a.Length / 2].ToString();
            }
            return output;
        }
    }
}
