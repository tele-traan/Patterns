namespace TemplateMethod;

public class Elder : Human
{
    public Elder(string name) : base(name) { }
    protected override void WakeUp()
    {
        Console.WriteLine($"Старик {Name} проснулся в 9:00.");
    }

    protected override void Eat()
    {
        Console.WriteLine($"Старик {Name} сам приготовил и съел завтрак из своих продуктов.");
    }

    protected override void DoActivity()
    {
        Console.WriteLine($"Старик {Name} весь день ходил по рынкам своего города.");
    }

    protected override void Sleep()
    {
        Console.WriteLine($"Старик {Name} хорошо заснул в 22:00.\n");
    }
}