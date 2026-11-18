using System;

class Program
{
    static void Main(string[] args)
    {
        //create fractions using the 3 constructors in fractions.cs
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        //displays fractions and decimal values
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test getters
        Console.WriteLine(f3.GetTop());
        Console.WriteLine(f3.GetBottom());

        // Test setters
        f3.SetTop(5);
        f3.SetBottom(8);

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}