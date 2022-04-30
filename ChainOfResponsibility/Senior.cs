namespace ChainOfResponsibility;

public class Senior : TaskChecker
{
    public Senior(string name) : base(name){}
    public override void HandleTaskChecking(TestTask task)
    {
        if (task.Difficulty < 100)
        {
            Console.WriteLine($"Сеньор {Name} проверил задачку\n");
        }
        else Console.WriteLine("Эта задачка оказалась сложной даже для сеньора");
    }
}