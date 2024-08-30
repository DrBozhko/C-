namespace ConsoleApp1.Practice6;

public class Car : Vehicle
{
    public Car(string model) : base(model)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine($"{model}: Car is ready to move.");
    }

    public override void StopEngine()
    {
        Console.WriteLine($"{model}: Car stopped.");
        base.StopEngine();
    }
}