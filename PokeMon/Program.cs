using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); 
            int distance = int.Parse(Console.ReadLine());  
            int exhaustFactor = int.Parse(Console.ReadLine());
            double moreExhausted = (double)pokePower / 2;
            int targetsCount = 0;
            int countOfTargets = pokePower / distance;
            int remainingPower = pokePower % distance;
            if (countOfTargets % 2 == 0 && remainingPower == 0 && exhaustFactor > 0)
            {
                pokePower = pokePower / 2 + ((pokePower / 2) / exhaustFactor);
            }
            int targets = pokePower / distance;
            int power = pokePower % distance;
            Console.WriteLine(power);
            Console.WriteLine(targets);
        }
    }
}
