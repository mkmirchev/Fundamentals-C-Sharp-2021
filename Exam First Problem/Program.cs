using System;
using System.Collections.Generic;
using System.Linq;
namespace Exam_First_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "Done")
                {
                    break;
                }
                if (input[0] == "Change")
                {
                    if (str.Contains(input[1]))
                    {
                        str = str.Replace((char)char.Parse(input[1]), (char)char.Parse(input[2]));
                    }
                    Console.WriteLine(str);
                }
                else if (input[0] == "Includes")
                {
                    if (str.Contains(input[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (input[0] == "End")
                {
                    if (str.EndsWith(input[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (input[0] == "Uppercase")
                {
                   str = str.ToUpper();
                    Console.WriteLine(str);
                }
                else if (input[0] == "FindIndex")
                {
                    int a = str.IndexOfAny(input[1].ToCharArray());
                    Console.WriteLine(a);
                }
                else if (input[0] == "Cut")
                {
                    string sub = str.Substring(int.Parse(input[1]), int.Parse(input[2]));
                    str = sub;
                    Console.WriteLine(str);
                }
            }
        }
    }
}
