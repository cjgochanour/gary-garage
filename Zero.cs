using System;

namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes: Zoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero turns ever so gently to the {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero comes to a gentle, complete stop.");
        }
    }
}