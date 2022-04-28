namespace Factory;

public abstract class School
{
    public string SchoolName { get; set; }
    public School(string name)
    {
        SchoolName = name;
    }
    public abstract void DisplayInfo();
    public abstract Worker GraduatePupil();
}