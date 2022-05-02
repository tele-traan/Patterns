namespace Builder;

public abstract class Vehicle
{
    public string VehicleName { get; }
    protected Vehicle(string name) => VehicleName = name;
    public string? Engine { get; set; }
    public string? Frame { get; set; }
    public string? MovingParts { get; set; }

    public void Display()
    {
        Console.WriteLine($"Транспортное средство {VehicleName}");
        Console.WriteLine($"Двигатель: {Engine}");
        Console.WriteLine($"Корпус: {Frame}");
        Console.WriteLine($"Движущие части: {MovingParts}\n");
    }
}