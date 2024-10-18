namespace Abstract_class.Models
{
    internal abstract class Vehicle
    {
        public string FactoryName;
        public string Model;
        public string Color;
        public double driveTime;
        public double drivePath;


        protected Vehicle(string factoryname, string model, string color, double drivetime, double drivepath)
        {
            FactoryName = factoryname;
            Model = model;
            Color = color;
            DriveTime = drivetime;
            DrivePath = drivepath;
        }

        public double DriveTime
        {
            get { return driveTime; }
            set
            {
                driveTime = value;
                if (driveTime == 0)
                {
                    drivePath = 0;
                }
            }
        }

        public double DrivePath
        {
            get { return drivePath; }
            set
            {
                if (driveTime > 0)
                {
                    drivePath = value;
                }
                else
                {
                    drivePath = 0;
                }
            }
        }
        public void AverageSpeed()
        {
            if (DriveTime > 0)
            {
                Console.WriteLine($"Average Speed = {DrivePath / DriveTime}");
            }
            else
            {
                Console.WriteLine("You didnt drive.");
            }
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory Name: {FactoryName}, Model: {Model}, Color: {Color}, DriveTime: {DriveTime}, DrivePath: {DrivePath}");
        }

        public override string ToString()
        {
            return $"Factory Name: {FactoryName}, Model: {Model}";
        }

        public abstract void DefineNatureHarmness();
    }
}
