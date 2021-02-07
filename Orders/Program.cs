using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            calculateOrder(product,quantity);
        }
        static void calculateOrder(string input, int quantity)
        {
            double price = 0;
            switch (input)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1.0;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2.0;
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0:F2}",price*quantity);
        }
    }
}
