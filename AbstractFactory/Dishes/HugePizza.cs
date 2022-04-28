namespace AbstractFactory;

public class HugePizza : ExpensiveDish
{
    public int SlicesAmount { get; }

    public HugePizza(int slicesAmount, string name) : base(name)
    {
        SlicesAmount = slicesAmount;
    }
}