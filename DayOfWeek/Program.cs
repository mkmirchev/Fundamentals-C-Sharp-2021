using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {"Monday", "Tuesday","Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int input = int.Parse(Console.ReadLine());
            if (input > 0 && input < 8)
            {
                Console.WriteLine(daysOfWeek[input-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
