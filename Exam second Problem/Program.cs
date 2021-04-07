using System;
using System.Text.RegularExpressions;

namespace Exam_second_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int regs = int.Parse(Console.ReadLine());
            string namePattern = @"(U\$)(?<name>[A-Z][a-z]{2,})(U\$)";
            string passPattern = @"(U\$)(?<pass>[A-Z][a-z]{2,})(U\$)";
            for (int i = 0; i < regs; i++)
            {
                string input = Console.ReadLine();
                
            }
        }
    }
}
