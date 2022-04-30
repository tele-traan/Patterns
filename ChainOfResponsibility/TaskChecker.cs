namespace ChainOfResponsibility;

public abstract class TaskChecker
{
    protected readonly TaskChecker? Next;
    public string Name { get; }

    protected TaskChecker(string name, TaskChecker? next = default)
    {
        Name = name;    
        Next = next;
    }

    public abstract void HandleTaskChecking(TestTask task);
}