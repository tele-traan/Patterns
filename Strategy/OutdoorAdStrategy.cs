namespace Strategy;

public class OutdoorAdStrategy : AdvertisingStrategy
{
    public OutdoorAdStrategy(Company c) : base(c) { }
    public override void Advertise()
    {
        Console.WriteLine($"Компания {Company.Name} рекламируется с помощью наружной рекламы.");
    }
}