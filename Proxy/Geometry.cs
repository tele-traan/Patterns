namespace Proxy;

public class Geometry
{
    public double GetCircleSquare(double radius) => Math.PI * radius * radius;
    public double GetTriangleSquare(double height, double side) => height * side / 2;
    public double GetRectangleSquare(double width, double height) => width*height;
}