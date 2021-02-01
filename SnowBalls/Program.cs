using System;
using System.Numerics;
namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            int bestsnowballSnow = 0;
            int bestsnowballTime = 0;
            int bestsnowballQ = 0;
            BigInteger bestsnowballValue = 0;
            for (int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                int div = snowballSnow / snowballTime;
                BigInteger snowballValue = BigInteger.Pow(div, snowballQuality);
                if (bestsnowballValue <= snowballValue)
                {
                    bestsnowballSnow = snowballSnow;
                    bestsnowballTime = snowballTime;
                    bestsnowballQ = snowballQuality;
                    bestsnowballValue = snowballValue;
                }
            }
            Console.WriteLine($"{bestsnowballSnow} : {bestsnowballTime} = {bestsnowballValue} ({bestsnowballQ})");
        }
    }
}
