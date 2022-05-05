using Proxy;

Geometry geometry = new();
GeometryProxy proxy = new(geometry);
double circleSq = proxy.GetCircleSquare(10);
double triangleSq = proxy.GetTriangleSquare(3, 4);
double rectangleSq = proxy.GetRectangleSquare(10, 20);

Console.WriteLine($"Площадь круга с радиусом 10: {circleSq}");
Console.WriteLine($"Площадь треугольника с высотой 3 и основанием 4: {triangleSq}");
Console.WriteLine($"Площадь прямоугольника со сторонами 10 и 20: {rectangleSq}");