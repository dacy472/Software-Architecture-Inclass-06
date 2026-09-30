using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class IndustrialRobot : RobotPrototype
    {
        public string IndustrialTask;

        public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.IndustrialTask = industrialTask;
        }

        public override RobotPrototype Clone()
        {
            return new IndustrialRobot(this.modelName, this.batteryCapacity, this.softwareVersion, this.IndustrialTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"IndustrialRobot: {modelName} | Battery: {batteryCapacity}h | Software: v{softwareVersion} | Task: {IndustrialTask}");
        }
    }
}
