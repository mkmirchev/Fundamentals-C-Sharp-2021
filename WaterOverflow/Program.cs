using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsToRead = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int currentLiters = 0;
            for (int i = 0; i < rowsToRead; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (currentLiters + liters < tankCapacity )
                {
                    currentLiters += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(currentLiters);
        }
    }
}
