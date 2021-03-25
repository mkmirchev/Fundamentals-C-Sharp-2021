using System;

namespace Replace_repeating_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = input[0].ToString();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != output[count])
                {
                    count++;
                    output += input[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}
