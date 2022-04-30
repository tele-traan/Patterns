namespace ChainOfResponsibility;

public class Intern
{
    private string Name { get; }
    public Intern(string name)
    {
        Name = name;
    }

    public void ApplyForVacancy(TestTask task, TaskChecker checker)
    {
        Console.WriteLine($"Стажёр {Name} сделал задачку {task.Title} и отправил её на проверку работникам компани\n");
        checker.HandleTaskChecking(task);
    }
}