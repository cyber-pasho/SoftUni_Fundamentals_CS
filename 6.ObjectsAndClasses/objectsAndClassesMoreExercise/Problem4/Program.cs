namespace Problem4
{
    internal class Program
    {
        static void Main()
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carsCount; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ")
                    .ToList();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model,engine,cargo);
                cars.Add(car);

            }
            string type = Console.ReadLine();
            foreach (var car in cars)
            {
                car.TypeAction(type);
            }
        }
    }
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }
        public void TypeAction(string type)
        {
            switch (type)
            {
                case "fragile":
                    if (Cargo.CargoWeight < 1000 && Cargo.CargoType == "fragile")
                    {
                        Console.WriteLine($"{Model}");
                    }
                    break;
                case "flamable":
                    if (Engine.EnginePower > 250 && Cargo.CargoType == "flamable")
                    {
                        Console.WriteLine($"{Model}");
                    }
                    break;
                default:
                    break;
            }
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    public class  Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

    }
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}