namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Black",
                MaximumOccupancy = 2,
                BatteryKWh = 16.4
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Silver",
                MaximumOccupancy = 5,
                BatteryKWh = 8.3
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = 4,
                FuelCapacity = 1.2
            };
            Ram bigTruck = new Ram()
            {
                MainColor = "Pink",
                MaximumOccupancy = 5,
                FuelCapacity = 1.1
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
        }
    }
}