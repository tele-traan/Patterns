namespace Factory;

public class TypicalMbouSosh : School
{
    public TypicalMbouSosh(string name) : base(name) { }

    public override void DisplayInfo()
    {
        Console.WriteLine(SchoolName);
        Console.WriteLine("Обычная МБОУ СОШ. Выпускает учеников со средним образованием\n");
    }
    public override Worker GraduatePupil()
    {
        return new Worker(Education.Secondary);
    }
}