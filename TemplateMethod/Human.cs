namespace TemplateMethod;

public abstract class Human
{
    protected string Name { get; }

    public Human(string name)
    {
        Name = name;
    }
    protected abstract void WakeUp();
    protected abstract void Eat();
    protected abstract void DoActivity();
    protected abstract void Sleep();

    public void DoDailyCycle()
    {
        WakeUp();
        Eat();
        DoActivity();
        Sleep();
    }
}