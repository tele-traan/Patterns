namespace Factory;

public abstract class Company
{
    public List<Worker> Employees { get; set; }
    public string CompanyName { get; set; }
    public Company(string name)
    {
        CompanyName = name;
        Employees = new List<Worker>();
    }

    public abstract void HireWorker(Worker newWorker);
}