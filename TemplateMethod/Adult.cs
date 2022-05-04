namespace TemplateMethod;

public class Adult : Human
{
    public Adult(string name) : base(name) { }

    protected override void WakeUp()
    {
        Console.WriteLine($"Взрослый {Name} проснулся достаточно рано.");
    }

    protected override void Eat()
    {
        Console.WriteLine($"Взрослый {Name} позавтракал на работе.");
    }

    protected override void DoActivity()
    {
        Console.WriteLine($"Взрослый {Name} весь день работал.");
    }

    protected override void Sleep()
    {
        Console.WriteLine($"Взрослый {Name} заснул достаточно поздно.\n");
    }
}