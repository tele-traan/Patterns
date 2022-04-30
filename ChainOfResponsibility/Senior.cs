namespace ChainOfResponsibility;

public class Senior : TaskChecker
{
    public Senior(string name) : base(name){}
    public override void HandleTaskChecking(TestTask task)
    {
        Console.WriteLine(
            task.Difficulty < 100
            ? $"Сеньор {Name} проверил задачку\n"
            : "Эта задачка оказалась сложной даже для сеньора"
            );
    }
}