namespace Builder;

public class Manufacturer
{
    private readonly string _name;
    public Manufacturer(string name) => _name = name;
    public void Compose(Factory factory)
    {
        factory.AddEngine();
        factory.AddFrame();
        factory.AddMovingParts();
        Console.WriteLine($"{_name} собрал транспортное средство\n");
    }
}