using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // This part of the program is the default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        // This is not stored as a member variable.
        string fractionNumeratorDenominator = $"{_top}/{_bottom}";
        return fractionNumeratorDenominator;
    }

    public double GetDecimalValue()
    {
        // This is not stored as a member variable.
        return (double)_top / (double)_bottom;
    }
}