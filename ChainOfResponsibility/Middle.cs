namespace ChainOfResponsibility;

public class Middle : TaskChecker
{
    public Middle(string name, TaskChecker next): base(name, next){}
    public override void HandleTaskChecking(TestTask task)
    {
        if (task.Difficulty < 50)
        {
            Console.WriteLine($"Миддл {Name} проверил задачку\n");
        }
        else
        {
            Console.WriteLine("Миддл недостаточно квалифицирован, чтобы проверять такие задачки.");
            Console.WriteLine("Он попросил работника выше грейдом сделать это за него.\n");
            Next?.HandleTaskChecking(task);
        }
    }
}