using System;

namespace Problem 1
    class Program
{
    static void Main(string[] args)
    {
        //input data
        decimal budget = decimal.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        decimal flourPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal apronPrice = decimal.Parse(Console.ReadLine());

        //data processing
        int freeFlourPackage = students / 5; // every 5 package of flour is free
        int paidFlourPackages = students - freeFlourPackage;
        // buy 20% more apron rounded to next integet
        int apronNeeded = (int)Math.Ceiling(students * 1.2);
        decimal costs = paidFlourPackages * flourPrice + students * 10 * eggsPrice + apronNeeded * apronPrice;

        //output data if smth else smth
        if (budget >= costs)
        {
            Console.WriteLine("Items purchased for {0:F2}$.", costs);
        }
        else
        {
            Console.WriteLine("{0:F2}$ more needed.", costs - budget);
        }
    }
}
}
