namespace Strategy;

public abstract class AdvertisingStrategy
{
    protected Company Company { get; }
    protected AdvertisingStrategy(Company c)
    {
        Company = c;
    }
    public abstract void Advertise();
}