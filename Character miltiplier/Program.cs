using System;
using System.Linq;

namespace Character_miltiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(CharSum(input[0],input[1]));
        }

        public static int CharSum(string a, string b)
        {
            int output = 0;
            if (a.Length >= b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    output += a[i] * b[i];
                }
                for (int s = b.Length; s < a.Length; s++)
                {
                    output += a[s];
                }
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    output += a[i] * b[i];
                }
                for (int s = a.Length; s < b.Length; s++)
                {
                    output += b[s];
                }
            }
            return output;
        }
    }
}
