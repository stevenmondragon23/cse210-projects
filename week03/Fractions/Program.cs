using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*Fraction Fractions = new Fraction();
        Fractions.Fraction();
        Fractions.Fraction(5);
        Fractions.Fraction(1, 2);*/

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractString());
        Console.WriteLine(f1.GetDecimValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractString());
        Console.WriteLine(f2.GetDecimValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractString());
        Console.WriteLine(f3.GetDecimValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractString());
        Console.WriteLine(f4.GetDecimValue());
    }
}