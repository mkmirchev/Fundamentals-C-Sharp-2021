using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            float pi = (float)Math.PI;
            double volume = 0;
            string maxKegName = string.Empty;
            double maxVolume = 0;
            for (int i = 0; i < kegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.Pow(radius, 2.0) * (double)pi * (double)height;
                if (maxVolume < volume)
                {
                    maxKegName = model;
                    maxVolume = volume;
                }
            }
            Console.WriteLine(maxKegName);
        }
    }
}
