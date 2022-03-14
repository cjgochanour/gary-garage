using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; } = 10;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes: RRrrrrrummbbble!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram crosses all 3 lanes to the {direction} direction without looking.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway");
        }
    }
}