namespace AbstractFactory;

public class Burger : CheapDish
{
    public int CutletsAmount { get; }

    public Burger(int cutletsAmount, string name) : base(name)
    {
        CutletsAmount = cutletsAmount;
    }
}