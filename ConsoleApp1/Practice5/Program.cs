namespace ConsoleApp1.Practice5;

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Transport> transports = new List<Transport>
        {
            new Car("Toyota Camry", 240, 5, "Petrol", 4, true, "Automatic"),
            new Bicycle("Mountain Bike", 50, 1, "Disc", true, 21),
            new Cart("Wooden Cart", 20, 2, 4, "Wood", false)
        };

        DisplayTransports(transports);

        // Add a new Car
        var newCar = new Car("Honda Civic", 220, 5, "Petrol", 4, true, "Manual");
        AddTransport(transports, newCar);

        // Remove the Bicycle
        RemoveTransport(transports, transports[1]);

        // Edit the Cart
        EditTransport(transports[1], new Cart("Metal Cart", 30, 3, 4, "Metal", true));

        Console.WriteLine("\nAfter modifications:");
        DisplayTransports(transports);
    }

    public static void DisplayTransports(List<Transport> transports)
    {
        foreach (var transport in transports)
        {
            Console.WriteLine(transport);
        }
    }

    public static void AddTransport(List<Transport> transports, Transport transport)
    {
        transports.Add(transport);
    }

    public static void RemoveTransport(List<Transport> transports, Transport transport)
    {
        transports.Remove(transport);
    }

    public static void EditTransport(Transport oldTransport, Transport newTransport)
    {
        oldTransport.Name = newTransport.Name;
        oldTransport.MaxSpeed = newTransport.MaxSpeed;
        oldTransport.Capacity = newTransport.Capacity;
        oldTransport.FuelType = newTransport.FuelType;

        if (oldTransport is Car oldCar && newTransport is Car newCar)
        {
            oldCar.NumberOfDoors = newCar.NumberOfDoors;
            oldCar.HasAirConditioning = newCar.HasAirConditioning;
            oldCar.TransmissionType = newCar.TransmissionType;
        }
        else if (oldTransport is Bicycle oldBicycle && newTransport is Bicycle newBicycle)
        {
            oldBicycle.HasGears = newBicycle.HasGears;
            oldBicycle.GearCount = newBicycle.GearCount;
            oldBicycle.BrakeType = newBicycle.BrakeType;
        }
        else if (oldTransport is Cart oldCart && newTransport is Cart newCart)
        {
            oldCart.NumberOfWheels = newCart.NumberOfWheels;
            oldCart.Material = newCart.Material;
            oldCart.HasCover = newCart.HasCover;
        }
    }
}