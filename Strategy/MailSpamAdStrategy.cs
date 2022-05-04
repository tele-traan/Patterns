namespace Strategy;

public class MailSpamAdStrategy : AdvertisingStrategy
{
    public MailSpamAdStrategy(Company c) : base(c) { }

    public override void Advertise()
    {
        Console.WriteLine($"Компания {Company.Name} рекламируется с помощью рассылок на электронные почты.");
    }
}