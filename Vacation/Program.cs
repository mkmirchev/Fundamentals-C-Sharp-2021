using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            int groupSize = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double discount = 0;
            double ticketPrice = 0;
            double totalPrice = 0;

            //data processing
            switch (groupType)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        ticketPrice = 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        ticketPrice = 9.80;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        ticketPrice = 10.46;
                    }
                    break;
                case "Business":
                    if (dayOfWeek == "Friday")
                    {
                        ticketPrice = 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        ticketPrice = 15.60;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        ticketPrice = 16.00;
                    }
                    break;
                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        ticketPrice = 15.00;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        ticketPrice = 20.00;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        ticketPrice = 22.50;
                    }
                    break;
                default:
                    break;
            }
            if (groupType == "Students" && groupSize >= 30)
            {
                discount = 0.15;
            }
            if (groupType == "Business" && groupSize >= 100)
            {
                groupSize -= 10;
            }
            if (groupType == "Regular" && groupSize >= 10 && groupSize <= 20)
            {
                discount = 0.05;
            }
            totalPrice = groupSize * ticketPrice*(1-discount);

            //output data
            Console.WriteLine("Total price: {0:F2}", totalPrice);
        }
    }
}
