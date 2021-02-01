using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int strings = int.Parse(Console.ReadLine());
            char startBracket = '(';
            bool isOpen = false;
            bool isClosed = false;
            int count = 0;
            bool isBalanced = true;
            char endBracket = ')';
            for (int i = 0; i < strings; i++)
            {
                string input = Console.ReadLine();
                if (char.TryParse(input, out char result))
                {
                    if (char.Parse(input) == startBracket && isClosed == false && isOpen == false) // Check first opening bracket
                    {
                        isOpen = true;
                    }
                    else if (char.Parse(input) == endBracket && isOpen == true && isClosed == false) // Check for closing an opened brakcet
                    {
                        isClosed = true;
                        isOpen = false;
                    }
                    else if (char.Parse(input) == startBracket && isClosed == true && isOpen == false) // Check next opening bracket
                    {
                        isOpen = true;
                        isClosed = false;
                    }
                    else if (char.Parse(input) == endBracket && isOpen == false && isClosed == false ||
                             char.Parse(input) == startBracket && isClosed == false && isOpen == true)
                    {
                        isOpen = true;
                        isClosed = true;
                    }
                }
            }
            if (isOpen == false && isClosed == true)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
