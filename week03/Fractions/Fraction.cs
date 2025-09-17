using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class Fraction

{
    private int _top;
    private int _bottom;

    /*----------------------------------*/
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");

    }

    /*-------------------------------------------*/
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

        Console.WriteLine($"{_top}/{_bottom}");

    }
    /*--------------------------------------------------*/
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        Console.WriteLine($"{_top}/{_bottom}");
    }

/*------------------------------------------------------------*/

    public string GetFractString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

/*------------------------------------------------------------*/

    public double GetDecimValue()
    {
        return (double)_top / (double)_bottom;
    }
}
