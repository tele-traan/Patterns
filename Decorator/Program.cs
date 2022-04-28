namespace Decorator;

class Program
{
    static void Main()
    {
        Company transportationCompany = new TransportationCompany("ООО РусЛогистикс");
        Company shipCompany = new ShipTransportationCompany(transportationCompany);
        Company bargeCompany = new BargeTransportationCompany(shipCompany);
        bargeCompany.Operation("Отправка груза из Санкт-Петербурга в Индию");
    }
}