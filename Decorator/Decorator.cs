namespace Decorator;

public abstract class Decorator : Company
{
    protected Company Company { get; }

    protected Decorator(Company c) : base(c.Name)
    {
        Company = c;
    }

    public override void Operation(string operationName)
    {
        Company.Operation(operationName);
    }
}