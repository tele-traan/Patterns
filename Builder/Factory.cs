namespace Builder;

public abstract class Factory
{
    protected Vehicle ConstructedVehicle { get; }

    protected Factory(Vehicle vehicle)
    {
        ConstructedVehicle = vehicle;
    }
    public abstract void AddEngine();
    public abstract void AddFrame();
    public abstract void AddMovingParts();

    public Vehicle GetComposedVehicle()
    {
        return ConstructedVehicle;
    }
}