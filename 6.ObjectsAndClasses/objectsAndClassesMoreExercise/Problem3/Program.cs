namespace Problem3
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
                    .ToArray();
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double fuelPerKM = double.Parse(input[2]);
                Car car = new Car(model,fuel,fuelPerKM);
                cars.Add(car);
            }
            string statement;
            while ((statement = Console.ReadLine()) != "End" && !string.IsNullOrWhiteSpace(statement))
            {
                var action = statement
                    .Split(" ")
                    .ToArray();
                string operation = action[0];
                string model = action[1];
                int distance = int.Parse(action[2]);
                var currentCar = cars.FirstOrDefault(c => c.Model == model);
                currentCar?
                    .CanTravel(distance);
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
    public class Car
    {
        public Car(string model, double fuel, double fuelPerKM)
        {
            Model = model;
            Fuel = fuel;
            FuelPerKM = fuelPerKM;
            Distance = 0;
        }
        public bool CanTravel(int distance)
        {
            double fuelConsumed = distance * FuelPerKM;
            if (fuelConsumed >= Fuel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return false;
            }
            else
            {
                Fuel -= fuelConsumed;
                Distance += distance;
                return true;
            }
        }
        public override string ToString()
        {
            return $"{Model} {Fuel:f2} {Distance}";
        }

        public string Model { get; set; }
        public double Fuel { get; set; }
        public double FuelPerKM { get; set; }
        public int Distance { get; set; }
    }
}