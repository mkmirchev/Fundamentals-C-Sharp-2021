using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue ctlg = new Catalogue();
            while (true)
            {
                List<string> input = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "end")
                {
                    List<Car> outputCars = ctlg.Cars.OrderBy(x => x.Vehicle.brand).ToList();
                    List<Truck> outputTrucks = ctlg.Trucks.OrderBy(y => y.Vehicle.brand).ToList();
                    if (outputCars.Count > 0)
                    {
                        Console.WriteLine("Cars:");
                        for (int i = 0; i < outputCars.Count; i++)
                        {
                            Console.WriteLine($"{outputCars[i].Vehicle.brand}: {outputCars[i].Vehicle.model} - {outputCars[i].power}hp");
                        }
                    }
                    if (outputTrucks.Count > 0)
                    {
                            Console.WriteLine("Trucks:");
                            for (int i = 0; i < outputTrucks.Count; i++)
                            {
                                    Console.WriteLine($"{outputTrucks[i].Vehicle.brand}: {outputTrucks[i].Vehicle.model} - {outputTrucks[i].mass}kg");
                            }
                    }
                    break;
                }
                else if (input[0] == "Car")
                {
                    string brand = input[1];
                    string model = input[2];
                    int power = int.Parse(input[3]);
                    Car car = new Car();
                    car.Vehicle.brand = brand;
                    car.Vehicle.model = model;
                    car.power = power;
                    ctlg.Cars.Add(car);
                }
                else if (input[0] == "Truck")
                {
                    string brand = input[1];
                    string model = input[2];
                    int mass = int.Parse(input[3]);
                    Truck truck = new Truck();
                    truck.Vehicle.brand = brand;
                    truck.Vehicle.model = model;
                    truck.mass = mass;
                    ctlg.Trucks.Add(truck);
                }
            }
        }
    }

    class Vehicle
    {
        public string brand { get; set; }
        public string model { get; set; }
    }

    class Car
    {
        public Car()
        {  
           Vehicle = new Vehicle();
        }
        public Vehicle Vehicle { get; set; }
        public int power { get; set; }
    }
    class Truck
    {
        public Truck()
        {
            Vehicle = new Vehicle();
        }
        public Vehicle Vehicle { get; set; }
        public int mass { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
            {
                 Cars = new List<Car>();
                 Trucks = new List<Truck>();
            }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}


