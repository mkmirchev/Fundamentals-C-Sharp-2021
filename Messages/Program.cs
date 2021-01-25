using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alpfabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            string input;
            int digit;
            int indx;
            int offset;
            string output = "";
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine(output);
                    break;
                }
                if (int.Parse(input[0].ToString()) == 0)
                {
                    output = output + " ";
                }
                else
                {
                    digit = int.Parse(input[0].ToString());
                    offset = (digit - 2) * 3;
                    indx = offset + input.Length - 1;
                    if (digit == 8 || digit == 9)
                    {
                        offset += 1;
                    }
                    indx = offset + input.Length - 1;
                    output = output + alpfabet[indx];
                }
            }
            Console.WriteLine(output);
        }
    }
}
