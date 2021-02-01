using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int chars = int.Parse(Console.ReadLine());
            string output = string.Empty;
            for (int i = 0; i < chars; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                char encryptedChar = (char)((int)currentChar + key);
                output += encryptedChar;
            }
            Console.WriteLine(output);
        }
    }
}
