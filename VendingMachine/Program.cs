using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = "Start";
            string end = "End";
            string input = "";
            double money = 0;
            double totalSum = 0;
            double price = 0;
            bool isInvalid = false;
            while (true)
            {
                input = Console.ReadLine();
                if (input == start)
                {
                    break;
                }
                try
                {
                    money = double.Parse(input);
                    if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                    {
                        totalSum += money;
                    }
                    else
                    {
                        Console.WriteLine("Cannot accept {0}", money);
                    }
                }
                finally
                {
                }
                if (input == start)
                {
                    break;
                }
            }
            while (true)
            {
                input = Console.ReadLine();
                isInvalid = false;
                if (input == end)
                {
                    Console.WriteLine("Change: {0:F2}", totalSum);
                    break;
                }
                switch (input)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        isInvalid = true;
                        break;
                }
                if (totalSum < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    if (isInvalid == false)
                    {
                        Console.WriteLine("Purchased {0}", input.ToLower());
                        totalSum -= price;
                    }
                }
            }
        }
    }
}
