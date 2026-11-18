using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    //Constructor #1 the default fraction of 1/1
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    //constructor #2 the default fraction of whole number/1 which gives whole number
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    //constructor #3 gives fraction with numerator and denominator
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    //gets the top number aka numerator
    {
        return _top;
    }

    public void SetTop(int top)
    //sets the top so one can change the top number
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    //sets the bottom so one can change the bottom number
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}