namespace AbstractFactory;

public abstract class ExpensiveDish
{
    public string DishName { get; }
    public bool IsPoorlyCooked { get; }

    protected ExpensiveDish(string name)
    {
        DishName = name;
        IsPoorlyCooked = Random.Shared.Next(0, 10) > 5;
    }
}