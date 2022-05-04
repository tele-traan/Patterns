using Strategy;

Company mailru = new("Mail.Ru Group");
Company yandex = new("Яндекс");
Company x5 = new("X5 Group");

yandex.AdStrategy = new OutdoorAdStrategy(yandex);
mailru.AdStrategy = new MailSpamAdStrategy(mailru);
x5.AdStrategy = new WaitStrategy(x5);

yandex.Advertise();
mailru.Advertise();
x5.Advertise();