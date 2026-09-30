using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ConsoleApp5;

public class Program
{
    public static void Main()
    {
        
        ServiceRobot serviceProto = new ServiceRobot("CareBot-X", 10, "1.0", "Patient Assistance");
        IndustrialRobot industrialProto = new IndustrialRobot("WeldMaster-500", 16, "2.1", "Welding");
        EntertainmentRobot entertainmentProto = new EntertainmentRobot("FunBot-Pro", 8, "3.0", "Interacting with Visitors");

        Console.WriteLine("=== Original Prototypes ===");
        serviceProto.DisplayDetails();
        industrialProto.DisplayDetails();
        entertainmentProto.DisplayDetails();

        
        ServiceRobot service2 = (ServiceRobot)serviceProto.Clone();
        service2.batteryCapacity = 14;                 

        IndustrialRobot industrial2 = (IndustrialRobot)industrialProto.Clone();
        industrial2.softwareVersion = "2.2";          

        IndustrialRobot industrial3 = (IndustrialRobot)industrialProto.Clone();
        industrial3.IndustrialTask = "Assembly";      
        industrial3.batteryCapacity = 20;

        EntertainmentRobot entertainment2 = (EntertainmentRobot)entertainmentProto.Clone();
        entertainment2.softwareVersion = "3.1";

        Console.WriteLine("\n=== Cloned & Customized Robots ===");
        service2.DisplayDetails();
        industrial2.DisplayDetails();
        industrial3.DisplayDetails();
        entertainment2.DisplayDetails();

      
        Console.WriteLine("\n=== Originals Unchanged ===");
        serviceProto.DisplayDetails();
        industrialProto.DisplayDetails();
    }
}
