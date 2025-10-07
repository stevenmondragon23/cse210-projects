using System.Drawing;

public class Square : Shape
{

    public Square(string squarecolor, double side) : base(squarecolor)
    {
        _side = side;
    }

    

    private double _side = 0.0;


    /*-------------------------------------------------*/


    public override double GetArea()
    {
        return _side * _side;
    }
}

