using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            if (dataType == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                GreaterOfTwo(a, b);
            }
            else if (dataType == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                GreaterOfTwo(a, b);
            }
            else
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                GreaterOfTwo(a, b);
            }
        }

        static void GreaterOfTwo(int a, int b)
        {
            if (a>b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        static void GreaterOfTwo(char a, char b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        static void GreaterOfTwo(string a, string b)
        {
            if (String.Compare(a, b) > 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
