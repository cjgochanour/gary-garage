using System;

namespace Garage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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