namespace Factory;

public class LowSalaryCompany : Company
{
    public LowSalaryCompany(string name) : base(name) { }
    public override void HireWorker(Worker newWorker)
    {
        if(newWorker.Education == Education.Higher)
        {
            Console.WriteLine($"К сожалению, работник {newWorker.FullName ?? ""} переквалифицирован");
            Console.WriteLine($"для работы в компании {CompanyName}.\n");
        }
        else
        {
            Employees.Add(newWorker);
            Console.WriteLine($"Работник {newWorker.FullName ?? ""} принят на работу ");
            Console.WriteLine($"в компанию {CompanyName}.\n");
        }
    }
}