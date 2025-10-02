
using FactoryPattern;

Console.WriteLine("How many tires does your vehicle have? ('Two, Four, Eighteen')");
var vehicleType = Console.ReadLine();

var vehicle = VehicleFactory.GetVehicle(vehicleType);

vehicle.Drive();