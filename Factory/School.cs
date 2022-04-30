namespace Factory;

public abstract class School
{
    protected string SchoolName { get; }
    protected School(string name)
    {
        SchoolName = name;
    }
    public abstract void DisplayInfo();
    public abstract Worker GraduatePupil();
}