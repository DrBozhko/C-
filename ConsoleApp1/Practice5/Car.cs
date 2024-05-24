namespace ConsoleApp1.Practice5;

public class Car : Transport
{
    public int NumberOfDoors { get; set; }
    public bool HasAirConditioning { get; set; }
    public string TransmissionType { get; set; }

    public Car(string name, int maxSpeed, int capacity, string fuelType, int numberOfDoors, bool hasAirConditioning, string transmissionType)
        : base(name, "Car", maxSpeed, capacity, fuelType)
    {
        NumberOfDoors = numberOfDoors;
        HasAirConditioning = hasAirConditioning;
        TransmissionType = transmissionType;
    }

    public override string ToString()
    {
        return base.ToString() + $", NumberOfDoors: {NumberOfDoors}, HasAirConditioning: {HasAirConditioning}, TransmissionType: {TransmissionType}";
    }
}