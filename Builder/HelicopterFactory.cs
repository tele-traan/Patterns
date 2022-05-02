namespace Builder;

public class HelicopterFactory : Factory
{
    public HelicopterFactory() : base(new Helicopter("Вертолёт Ансат")) { }

    public override void AddEngine()
    {
        ConstructedVehicle.Engine = "Вертолётный двигатель";
    }

    public override void AddFrame()
    {
        ConstructedVehicle.Frame = "Корпус вертолёта";
    }

    public override void AddMovingParts()
    {
        ConstructedVehicle.MovingParts = "Вертолётные лопасти";
    }
}