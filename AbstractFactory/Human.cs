namespace AbstractFactory;

public class Human
{
    public string Name { get; }
    public Human(string name) => Name = name;

    public void EatCheapDish(CheapDish dish)
    {
        Console.WriteLine($"{Name} ест дешёвый {dish.DishName}");
        if (dish is Burger b)
        {
            Console.WriteLine($"У этого бургера {b.CutletsAmount} котлеток");
        }

        if (dish is BusinessLunch l)
        {
            Console.WriteLine($"Гарнир: {l.Garnish}");
        }
        if (dish.IsOverdue)
        {
            Console.WriteLine("К сожалению, после этого он отравился :(");
        }
    }

    public void EatExpensiveDish(ExpensiveDish dish)
    {
        Console.WriteLine($"{Name} ест достаточно дорогой {dish.DishName}");
        if (dish is HugePizza p)
        {
            Console.WriteLine($"Эту пиццу разделили на {p.SlicesAmount} кусков");
        }

        if (dish is MarbleBeefSalad s)
        {
            Console.WriteLine($"Уровень прожарки мяса в этом салате: {s.DonenessLevel}");
        }

        if (dish.IsPoorlyCooked)
        {
            Console.WriteLine("К сожалению, повар плохо приготовил это блюдо");
        }
    }
}