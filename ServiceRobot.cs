using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class ServiceRobot : RobotPrototype
    {
        public string ServiceTask;

        public ServiceRobot(string modelName, int batteryCapacity, string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.ServiceTask = serviceTask;
        }

        public override RobotPrototype Clone()
        {
            return new ServiceRobot(this.modelName, this.batteryCapacity, this.softwareVersion, this.ServiceTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ServiceRobot: {modelName} | Battery: {batteryCapacity}h | Software: v{softwareVersion} | Task: {ServiceTask}");
        }
    }
}
