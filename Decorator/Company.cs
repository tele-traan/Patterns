namespace Decorator;

public abstract class Company
{
    public string Name { get; }

    protected Company(string name)
    {
        Name = name;
    }

    public abstract void Operation(string operationName);
}