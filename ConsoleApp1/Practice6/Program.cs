namespace ConsoleApp1.Practice6;

class Program
{
    static void Main()
    {
        IVehicle myCar = new Car("Toyota");
        myCar.StartEngine();
        myCar.StopEngine();
    }
}