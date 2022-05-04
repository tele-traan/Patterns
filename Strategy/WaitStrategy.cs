namespace Strategy;

public class WaitStrategy : AdvertisingStrategy
{
    public WaitStrategy(Company c) : base(c) { }

    public override void Advertise()
    {
        Console.WriteLine($"Компания {Company.Name} просто сидит и ждёт...");
    }
}