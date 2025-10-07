public class Circle : Shape
{
    public Circle(string circleColor, double radius) : base(circleColor)
    {
        _radius = radius;
    }
    
    private double _radius = 0.0;

    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}