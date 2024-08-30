namespace ConsoleApp1.Practice6;

public abstract class Vehicle : IVehicle
{
    public readonly string model;

    public Vehicle(string model)
    {
        this.model = model;
    }

    public virtual void StartEngine()
    {
        Console.WriteLine($"{model}: Engine started.");
    }

    public virtual void StopEngine()
    {
        Console.WriteLine($"{model}: Engine stopped.");
    }
}