using System;

namespace Extract_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string name = string.Empty;
            string extension = string.Empty;
            int dotIndex = input.IndexOf('.');
            int nameFirstIndex = input.LastIndexOf('\\');
            for (int i = nameFirstIndex+1; i < dotIndex; i++)
            {
                name += input[i];
            }
            for (int i = dotIndex+1; i < input.Length; i++)
            {
                extension += input[i];
            }
            Console.WriteLine("File name: {0}",name);
            Console.WriteLine("File extension: {0}",extension);
        }
    }
}
