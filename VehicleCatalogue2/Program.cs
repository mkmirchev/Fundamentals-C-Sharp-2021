using System;
using System.Linq;
using System.Collections.Generic;

namespace VehicleCatalogue2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            catalogue.Capacity = 50;
            while (true)
            {
                string[] inputStr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputStr[0] == "End")
                {
                    break;
                }
                Vehicle vhcl = new Vehicle();
                vhcl.VehicleType = inputStr[0];
                vhcl.Model= inputStr[1];
                vhcl.Color = inputStr[2];
                vhcl.Power = double.Parse(inputStr[3]);              
                catalogue.Add(vhcl);

            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    double carsHP = 0;
                    int carsCount = 0;
                    double trucksHP = 0;

                    foreach (var item in catalogue)
                    {
                        if (item.VehicleType == "car")
                        {
                            carsHP += item.Power;
                            carsCount++;
                        }
                        else if (item.VehicleType == "truck")
                        {
                            trucksHP += item.Power;
                        }
                    }
                    if (carsCount == 0)
                    {
                        Console.WriteLine("Cars have average horsepower of: 0.00.");
                    }
                    else
                    {
                        Console.WriteLine("Cars have average horsepower of: {0:F2}.", carsHP / carsCount);
                    }
                    if (catalogue.Count - carsCount == 0)
                    {
                        Console.WriteLine("Trucks have average horsepower of: 0.00.");
                    }
                    else
                    {
                        Console.WriteLine("Trucks have average horsepower of: {0:F2}.", trucksHP / (catalogue.Count - carsCount));
                    }
                    break;
                }
                else
                {
                    foreach (Vehicle currentVehicle in catalogue)
                    {
                        if (currentVehicle.Model == input)
                        {
                            if (currentVehicle.VehicleType == "car")
                            {
                                Console.WriteLine("Type: Car");
                            }
                            else if (currentVehicle.VehicleType == "truck")
                            {
                                Console.WriteLine("Type: Truck");
                            }
                            Console.WriteLine("Model: {0}", currentVehicle.Model);
                            Console.WriteLine("Color: {0}", currentVehicle.Color);
                            Console.WriteLine("Horsepower: {0}", currentVehicle.Power);
                        }
                    }
                }
            }
        }

        class Vehicle
        {
            public Vehicle(string type, string model, string color, double hp)
            {
                type = VehicleType;
                model = Model;
                color = Color;
                hp = Power;
            }
            public Vehicle()
            {

            }
            public string VehicleType { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Power { get; set; }
        }
    }
}
