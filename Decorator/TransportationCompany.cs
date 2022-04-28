namespace Decorator;

public class TransportationCompany : Company
{
    public TransportationCompany(string name) : base(name) { }
    public override void Operation(string operationName)
    {
        Console.WriteLine($"Транспортная компания {Name} выполнила заказ: {operationName}");
    }
}