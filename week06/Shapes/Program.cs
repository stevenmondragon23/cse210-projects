using System;

class Program
{
    static void Main(string[] args)
    {
        Shape squareForm = new Square("blue", 2);
        Shape circleForm = new Circle("Red", 10);
        Shape rectangleForm = new Rectangle("Gray", 10, 10);

        DisplayArea(squareForm);
        DisplayArea(circleForm);
        DisplayArea(rectangleForm);



    }

    public static void DisplayArea(Shape shape)
    {
        Console.WriteLine($"The color is {shape.GetColor()} and the area is {shape.GetArea()}");
    }
}