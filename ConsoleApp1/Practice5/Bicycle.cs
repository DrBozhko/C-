namespace ConsoleApp1.Practice5;

public class Bicycle : Transport
{
    public bool HasGears { get; set; }
    public int GearCount { get; set; }
    public string BrakeType { get; set; }

    public Bicycle(string name, int maxSpeed, int capacity, string brakeType, bool hasGears, int gearCount)
        : base(name, "Bicycle", maxSpeed, capacity, "None")
    {
        BrakeType = brakeType;
        HasGears = hasGears;
        GearCount = gearCount;
    }

    public override string ToString()
    {
        return base.ToString() + $", HasGears: {HasGears}, GearCount: {GearCount}, BrakeType: {BrakeType}";
    }
}