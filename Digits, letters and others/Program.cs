using System;

namespace Digits__letters_and_others
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string digits = string.Empty;
            string chars = string.Empty;
            string specials = string.Empty;
            foreach (char ch in str)
            {
                if (char.IsDigit(ch) == true)
                {
                    digits += ch;
                }
                else if (char.IsLetter(ch) == true)
                {
                    chars += ch;
                }
                else
                {
                    specials += ch;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(chars);
            Console.WriteLine(specials);
        }
    }
}
