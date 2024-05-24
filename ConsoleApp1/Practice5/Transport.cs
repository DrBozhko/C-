namespace ConsoleApp1.Practice5;

public class Transport
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int MaxSpeed { get; set; }
    public int Capacity { get; set; }
    public string FuelType { get; set; }

    public Transport(string name, string type, int maxSpeed, int capacity, string fuelType)
    {
        Name = name;
        Type = type;
        MaxSpeed = maxSpeed;
        Capacity = capacity;
        FuelType = fuelType;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Type: {Type}, MaxSpeed: {MaxSpeed} km/h, Capacity: {Capacity}, FuelType: {FuelType}";
    }
}