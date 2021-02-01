using System;

namespace DataTypeFinder
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
                if (int.TryParse(input,out int number))
                {
                    Console.WriteLine("{0} is integer type", input);
                }
                else if (float.TryParse(input, out float floatingNumber))
                {
                    Console.WriteLine("{0} is floating point type", input);
                }
                else if (char.TryParse(input, out char character))
                {
                    Console.WriteLine("{0} is character type", input);
                }
                else if (bool.TryParse(input,out bool check))
                {
                    Console.WriteLine("{0} is boolean type", input);
                }
                else
                {
                    Console.WriteLine("{0} is string type", input);
                }
            }

        }
    }
}
