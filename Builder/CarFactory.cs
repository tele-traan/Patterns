namespace Builder;

public class CarFactory : Factory
{
    public CarFactory() : base(new Car("Автомобиль Рено Логан")) { }

    public override void AddEngine()
    {
        ConstructedVehicle.Engine = "Автомобильный двигатель";
    }

    public override void AddFrame()
    {
        ConstructedVehicle.Frame = "Корпус автомобиля";
    }

    public override void AddMovingParts()
    {
        ConstructedVehicle.MovingParts = "Автомобильные колёса";
    }
}