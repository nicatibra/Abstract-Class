namespace Abstract_class.Models
{
    internal class Car : Vehicle
    {
        public byte DoorCount;
        public bool IsElectricCar;


        public Car(string factoryname, string model, string color, double drivetime, double drivepath, byte doorcount, bool iselectric) : base(factoryname, model, color, drivetime, drivepath)
        {
            DoorCount = doorcount;
            IsElectricCar = iselectric;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"DoorCoount: {DoorCount}, IsElectricCar: {IsElectricCar}");
        }

        public override void DefineNatureHarmness()
        {
            if (IsElectricCar)
            {
                Console.WriteLine($"Fuel Consumption of {FactoryName} {Model} is low.");
            }
            else
            {
                Console.WriteLine($"Fuel Consumption of {FactoryName} {Model} is high.");
            }
        }
    }
}
