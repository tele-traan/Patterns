namespace Strategy;

public class Company
{
    public string Name { get; }

    public Company(string name)
    {
        Name = name;
    }
    public int Popularity { get; private set; } = 0;
    public AdvertisingStrategy? AdStrategy { get; set; }

    public void Advertise()
    {
        AdStrategy?.Advertise();
        Popularity += 10;
    }
}