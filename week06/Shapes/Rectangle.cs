public class Rectangle : Shape
{


    public Rectangle(string rectanglecolor, double length, double width) : base(rectanglecolor)
    {
        _length = length;
        _width = width;
    }


    private double _length = 0.0;
    private double _width = 0.0;

    /*-------------------------------------------------*/

    public override double GetArea()
    {
        return _length * _width;
    }

}