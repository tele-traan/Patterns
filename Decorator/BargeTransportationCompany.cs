namespace Decorator;

public class BargeTransportationCompany : Decorator
{
    public BargeTransportationCompany(Company c) : base(c) {}

    public override void Operation(string operationName)
    {
        base.Operation(operationName);
        Console.WriteLine($"В качестве судов для перевозки \"{Name}\" использовала баржи.");
    }
}