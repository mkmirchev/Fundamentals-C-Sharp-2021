using System;
using System.Linq;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < input; i++)
            {
                List<string> secondInput = Console.ReadLine().Split(' ').ToList();
                Car currentCar = new Car();
                currentCar.Name = secondInput[0];
                currentCar.FuelAmount = double.Parse(secondInput[1]);
                currentCar.Consumption = double.Parse(secondInput[2]);
                cars.Add(currentCar);
            }
            while (true)
            {
                List<string> thirdInput = Console.ReadLine().Split(' ').ToList();
                if (thirdInput.Contains("End"))
                {
                    break;
                }
                Car currentCar = new Car();
                foreach (Car cr in cars)
                {
                    if (thirdInput[1] == cr.Name)
                    {
                        currentCar = cr;
                    }
                }
                currentCar.CheckDistance(double.Parse(thirdInput[2]));
            }
            foreach (Car item in cars)
            {
                    Console.WriteLine($"{item.Name} {item.FuelAmount:F2} {item.TravelDistance}");
            }
        }
    }

    class Car
    { 
        public string Name { get; set; }
        public double FuelAmount { get; set; }
        public double Consumption { get; set; }
        public double TravelDistance { get; set; }
        public Car()
        {
            string name = Name;
            double fuelAmount = FuelAmount;
            double consumption = Consumption;
            TravelDistance = 0;
        }
        public void CheckDistance(double distance)
        {
            if (distance > this.FuelAmount / this.Consumption)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.TravelDistance += distance;
                this.FuelAmount -= this.Consumption * distance;
            }
        }
    }
}
