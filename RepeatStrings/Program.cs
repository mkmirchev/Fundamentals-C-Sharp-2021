using System;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            string output = StringRepeater(input,a);
            Console.WriteLine(output);
        }
        private static string StringRepeater(string str, int rep)
        {
            string output = string.Empty;
            for (int i = 0; i < rep; i++)
            {
                output += str;
            }
            return output;
        }
    }
}
