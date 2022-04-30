namespace ChainOfResponsibility;

public class Junior : TaskChecker
{
    public Junior(string name, TaskChecker next) : base(name, next){}
    public override void HandleTaskChecking(TestTask task)
    {
        if (task.Difficulty < 10)
        {
            Console.WriteLine($"Джун {Name} проверил задачку\n");
        }
        else
        {
            Console.WriteLine("Джун недостаточно квалифицирован, чтобы проверять такие задачки.");
            Console.WriteLine("Он попросил работника выше грейдом сделать это вместо него.\n");
            Next?.HandleTaskChecking(task);
        }
    }
}