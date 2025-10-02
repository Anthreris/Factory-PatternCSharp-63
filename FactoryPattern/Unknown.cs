namespace FactoryPattern;

public class Unknown : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Creating new unidentified Vehicle.");
    }
}