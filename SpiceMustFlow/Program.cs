using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int count = 0;
            decimal totalYield = 0;
            while (input >= 100)
            {
                count++;
                totalYield += (input - 26);
                input -= 10;
            }
            if (input < 100 && count == 0)
            {
                Console.WriteLine(count);
                Console.WriteLine(totalYield);
            }
            else
            {
                Console.WriteLine(count);
                Console.WriteLine(totalYield-26); // decreasing yield by 26 for the last day
            }

        }
    }
}
