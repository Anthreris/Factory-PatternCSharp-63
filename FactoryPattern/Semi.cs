namespace FactoryPattern;

public class Semi : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Building a new Semi.");
    }
}