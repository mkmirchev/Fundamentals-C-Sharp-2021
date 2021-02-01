using System;

namespace TriplesofLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                char firstChar = (char)('a' + i);
                for (int j = 0; j < input; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (int l = 0; l < input; l++)
                    {
                        char thirdChar = (char)('a' + l);
                        Console.WriteLine(firstChar.ToString() + secondChar.ToString() + thirdChar.ToString());
                    }
                }
            }
        }
    }
}
