namespace Abstract_class.Models
{
    internal class Bicycle : Vehicle
    {
        public string Type;

        public Bicycle(string factoryname, string model, string color, double drivetime, double drivepath, string type) : base(factoryname, model, color, drivetime, drivepath)
        {
            Type = type;
        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine($"{FactoryName} {Model} does not consume fuel"); ;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Bicycle type: {Type}");
        }
    }
}
