using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowelCounter(input);
        }

        static void VowelCounter(string a)
        {
            int count = 0;
            foreach (var ch in a.ToLower())
            {
                if (ch == 'a' || ch=='o' || ch == 'e' || ch == 'i' || ch == 'u' || ch== 'y')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
