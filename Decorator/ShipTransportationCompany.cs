namespace Decorator;

public class ShipTransportationCompany : Decorator
{
    public ShipTransportationCompany(Company c) : base(c)
    {
    }

    public override void Operation(string operationName)
    {
        base.Operation(operationName);
        Console.WriteLine($"Компания {Name} отправляет грузы по воде.");
    }
}