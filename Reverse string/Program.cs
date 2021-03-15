using System;

namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string output = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    output += input[i];
                }
                Console.WriteLine(input + " = "+output);
            }
        }
    }
}
