namespace Proxy;

public class GeometryProxy
{
    private readonly Geometry _geometry;

    public GeometryProxy(Geometry geometry)
    {
        _geometry = geometry;
    }

    public double GetCircleSquare(double radius) 
        => _geometry.GetCircleSquare(radius);
    
    public double GetTriangleSquare(double height, double side) 
        => _geometry.GetTriangleSquare(height, side);
    
    public double GetRectangleSquare(double side1, double side2) 
        => _geometry.GetRectangleSquare(side1, side2);
}