using System.Runtime.InteropServices;

namespace FactoryPattern;

public class VehicleFactory
{
    public static IVehicle GetVehicle(string vehicleType)
    {
        switch (vehicleType.ToLower())
        {
            case "2":
            case "two":
                return new Motorcycle();
            case "4":
            case "four":
                return new Car();
            case "18":
            case "eighteen":
                return new Semi();
            default:
                return new Unknown();
        }
    }
}