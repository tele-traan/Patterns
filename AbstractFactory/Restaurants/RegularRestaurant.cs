namespace AbstractFactory;

public class RegularRestaurant : RestaurantFactory
{
    private static int Rng(int a, int b) => Random.Shared.Next(a, b);
    private static readonly string[] Garnishes = { "Пюре","Макароны","Картошка фри"};
    private static readonly string[] Lunches =
    {
        "Бизнес ланч с котлеткой", 
        "Бизнес-ланч по-французски", 
        "Бизнес ланч без мяса"
    };

    private static readonly string[] Salads =
    {
        "Салат \"Цезарь\" с мраморной говядиной",
        "Салат \"Сельдь под шубой\" с креветками из мраморной говядины"
    };
    private static (string, string) GetCurrentLunchMenu()
    {
        string garnish = Garnishes[Rng(0, 3)];
        string lunch = Lunches[Rng(0, 3)];
        return (garnish, lunch);
    }

    private static string GetCurrentSalad() => Salads[Rng(0, 1)];
    
    public override CheapDish ServeCheapDish()
    {
        (string garnish, string lunch) = GetCurrentLunchMenu();
        return new BusinessLunch(garnish, lunch);
    }

    public override ExpensiveDish ServeExpensiveDish()
    {
        var salad = GetCurrentSalad();
        return new MarbleBeefSalad(Rng(1, 5), salad);
    }
}