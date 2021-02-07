using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char chStart = char.Parse(Console.ReadLine());
            char chEnd= char.Parse(Console.ReadLine());
            PrintCharsInRange(chStart, chEnd);
        }

        static void PrintCharsInRange(char start, char stop)
        {
            int newStart;
            int newStop;
            if (start<stop)
            {
                newStart = start;
                newStop = stop;
            }
            else
            {
                newStart = stop;
                newStop = start;
            }
            for (int i = newStart+1; i < newStop; i++)
            {
                Console.Write((char)i+ " ");
            }
        }
    }
}
