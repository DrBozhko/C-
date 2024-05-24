namespace ConsoleApp1.Practice5;

public class Cart : Transport
{
    public int NumberOfWheels { get; set; }
    public string Material { get; set; }
    public bool HasCover { get; set; }

    public Cart(string name, int maxSpeed, int capacity, int numberOfWheels, string material, bool hasCover)
        : base(name, "Cart", maxSpeed, capacity, "None")
    {
        NumberOfWheels = numberOfWheels;
        Material = material;
        HasCover = hasCover;
    }

    public override string ToString()
    {
        return base.ToString() + $", NumberOfWheels: {NumberOfWheels}, Material: {Material}, HasCover: {HasCover}";
    }
}