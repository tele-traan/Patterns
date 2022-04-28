namespace Factory;

public class Worker
{
    public string? FullName { get; set; }
    public Education Education { get; set; }
    public Worker(Education education) => Education = education;


}