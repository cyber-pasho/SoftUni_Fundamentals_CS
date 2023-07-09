using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split('/')
                .ToArray();
            //
            List<Car> cars= new List<Car>();
            List<Truck> trucks= new List<Truck>();
            //
            string brand;
            string model;
            string weight;
            string horsePower;
            //
            while (input[0] != "end")
            {
                if (input[0] == "Car")
                {
                    brand = input[1];
                    model = input[2];
                    horsePower= input[3];
                    var car = new Car(brand, model, horsePower);
                    cars.Add(car);
                }
                else
                {
                    brand= input[1];
                    model = input[2];
                    weight = input[3];
                    var truck = new Truck(brand, model, weight);
                    trucks.Add(truck);
                }
                input = Console.ReadLine()
                .Split('/')
                .ToArray();
            }
            Console.WriteLine("Cars:");
            foreach (var car in cars.OrderBy(e => e.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var truck in trucks.OrderBy(e => e.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    public class Truck 
    {
        public Truck(string brand, string model, string weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    public class Car 
    {
        public Car (string brand, string model, string horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    public class VehicleCatalog
    {
        public VehicleCatalog(List<Car> cars, List<Truck> trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

}
