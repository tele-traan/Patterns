namespace Factory;

public class PrivateSchool : School
{
    public PrivateSchool(string name) : base(name) { }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Частная школа {SchoolName}");
        Console.WriteLine("Платное учебное заведение. Выпускает учеников с высшим образованием\n");
    }
    public override Worker GraduatePupil()
    {
        return new Worker(Education.Higher);
    }
}