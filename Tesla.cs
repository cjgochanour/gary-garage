using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; } = 25;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes: Silence.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla AI senses it is time to move {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla stops on a dime... and atop several children.");
        }
    }
}