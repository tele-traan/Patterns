namespace Factory;

public class HighSalaryCompany : Company
{
    public HighSalaryCompany(string name): base(name) { }
    public override void HireWorker(Worker newWorker)
    {
        if(newWorker.Education == Education.Secondary)
        {
            Console.WriteLine($"К сожалению, работник {newWorker.FullName ?? ""} недостаточно квалифицирован");
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