using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");

        Fraction f1Fraction = new Fraction();
        Console.WriteLine(f1Fraction.GetFractionString());
        Console.WriteLine(f1Fraction.GetDecimalValue());

        Fraction f2Fraction = new Fraction(5);
        Console.WriteLine(f2Fraction.GetFractionString());
        Console.WriteLine(f2Fraction.GetDecimalValue());

        Fraction f3Fraction = new Fraction(3, 4);
        Console.WriteLine(f3Fraction.GetFractionString());
        Console.WriteLine(f3Fraction.GetDecimalValue());

        Fraction f4Fraction = new Fraction(1, 3);
        Console.WriteLine(f4Fraction.GetFractionString());
        Console.WriteLine(f4Fraction.GetDecimalValue());
    }
}