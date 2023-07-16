using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Vehicle> vehicles = new List<Vehicle>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicleInput = input
                    .Split(' ');
                string type = vehicleInput[0];
                string model = vehicleInput[1];
                string color = vehicleInput[2];
                decimal horsepower = decimal.Parse(vehicleInput[3]);
                Vehicle newVehicle = new Vehicle(type, model, color, horsepower);
                vehicles.Add(newVehicle);
            }
            string input2;
            while ((input2 = Console.ReadLine()) != "Close the Catalogue")
            {
                string vehicleModel = input2;

                Vehicle found = vehicles.FirstOrDefault(v => v.Model == vehicleModel);
                if (found != null)
                {
                    Console.WriteLine(found);
                }
            }
            decimal averageHP = vehicles
                .Where(vehicle => vehicle.Type == Type.Car)
                .Select(vehicle => vehicle.Horsepower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

            averageHP = vehicles
                .Where(vehicle => vehicle.Type == Type.Truck)
                .Select(vehicle => vehicle.Horsepower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");
        }
    }
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, decimal horsepower)
        {
            Type = type == "car" ? Type.Car : Type.Truck;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public Type Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Horsepower { get; set; }
        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {Horsepower}";
        }
    }
    public enum Type
    {
        Car,
        Truck
    }
}