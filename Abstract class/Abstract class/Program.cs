using Abstract_class.Models;

namespace Abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes", "Cls", "Black", 2, 200, 4, false);
            Car car2 = new Car("Tesla", "Model S", "White", 1, 100, 4, true);


            car1.GetInfo();
            Console.WriteLine(car1.ToString());
            car1.AverageSpeed();
            car1.DefineNatureHarmness();

            Console.WriteLine("----------------------------------------------------------------------------------");

            Bicycle bicycle1 = new Bicycle("Speed", "BMX", "Red", 1, 25, "Road");
            Bicycle bicycle2 = new Bicycle("Start", "BMX", "Blue", 1, 30, "Offroad");

            bicycle1.GetInfo();
            Console.WriteLine(bicycle1.ToString());
            bicycle1.AverageSpeed();
            bicycle1.DefineNatureHarmness();

            Console.WriteLine("----------------------------------------------------------------------------------");

            Vehicle[] vehicles = { car1, car2, bicycle1, bicycle2 };
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.GetInfo();
                Console.WriteLine();
            }
        }
    }
}
