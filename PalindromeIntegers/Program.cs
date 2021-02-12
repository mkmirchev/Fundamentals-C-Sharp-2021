using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                IsPalindrome(input);
            }
        }


        static void IsPalindrome(string a)
        {
            bool isIt = true;
            int i = 0;
            int j = a.Length-1;
            while (i <= a.Length/2 && j >= a.Length/2)
            {
                if (a[i] != a[j])
                {
                    Console.WriteLine("false");
                    isIt = false;
                    break;
                }
                i++;
                j--;
            }
            if (isIt == true)
            {
                Console.WriteLine("true");
            }
        }

    }
}
