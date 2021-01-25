using System;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input = "";
            double gamePrice = 0;
            double totalSpend = 0;
                double startMoney = budget;
            while (true)
            {

                input = Console.ReadLine();
                if (input == "Game Time")
                {
                    if (budget == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}", totalSpend, startMoney - totalSpend);
                        break;
                    }
                }
                switch (input)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (budget - gamePrice >= 0 && gamePrice !=0)
                {
                    Console.WriteLine("Bought " + input);
                    totalSpend += gamePrice;
                    budget -= gamePrice;
                }
                else if (budget < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                }
                gamePrice = 0;
            }
        }
    }
}
