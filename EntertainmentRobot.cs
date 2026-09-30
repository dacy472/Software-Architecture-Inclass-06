using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class EntertainmentRobot : RobotPrototype
    {
        public string EntertainmentFeature; 

        public EntertainmentRobot(string modelName, int batteryCapacity, string softwareVersion, string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.EntertainmentFeature = entertainmentFeature;
        }

        public override RobotPrototype Clone()
        {
            return new EntertainmentRobot(this.modelName, this.batteryCapacity, this.softwareVersion, this.EntertainmentFeature);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"EntertainmentRobot: {modelName} | Battery: {batteryCapacity}h | Software: v{softwareVersion} | Feature: {EntertainmentFeature}");
        }
    }
}
