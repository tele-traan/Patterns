namespace TemplateMethod;

public class Child : Human
{
    public Child(string name) : base(name) { }
    protected override void WakeUp()
    {
        Console.WriteLine($"Ребёнок {Name} проснулся достаточно поздно.");
    }

    protected override void Eat()
    {
        Console.WriteLine($"Ребёнок {Name} съел то, что мама дала.");
    }

    protected override void DoActivity()
    {
        Console.WriteLine($"Ребёнок {Name} весь день игрался с игрушками.");
    }

    protected override void Sleep()
    {
        Console.WriteLine($"Ребёнок {Name} заснул достаточно рано.\n");
    }
}