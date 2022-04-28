namespace AbstractFactory;

public class MarbleBeefSalad : ExpensiveDish
{
    public int DonenessLevel { get; }

    public MarbleBeefSalad(int donenessLevel, string name) : base(name)
    {
        DonenessLevel = donenessLevel;
    }
}