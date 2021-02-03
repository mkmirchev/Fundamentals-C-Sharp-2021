using System;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading input
            string[] input = Console.ReadLine().Split(' ');

            //convert input to array of doubles
           float[] inputInDoubles = new float[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputInDoubles[i] = float.Parse(input[i]);
            }

            //rounding values and generating output
            foreach (var item in inputInDoubles)
            {
                Console.WriteLine("{0} => {1}",Convert.ToDecimal(item), Math.Round(Convert.ToDecimal(item), MidpointRounding.AwayFromZero));
            }
        }
    }
}
