namespace AbstractFactory;

public abstract class RestaurantFactory
{
    public abstract ExpensiveDish ServeExpensiveDish();
    public abstract CheapDish ServeCheapDish();
}