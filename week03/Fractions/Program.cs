using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // using first constructor
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction 1: {f1.GetFractionString()}");
        Console.WriteLine(f1.GetDecimaValue());

        // using second constructor
        Fraction f2 = new Fraction(6);
        Console.WriteLine($"Fraction 2: {f2.GetFractionString()}");
        Console.WriteLine(f2.GetDecimaValue());

        // using third constructor
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine($"Fraction 3: {f3.GetFractionString()}");
        Console.WriteLine(f3.GetDecimaValue());

        // using setter for top with first constructor
        Fraction f4 = new Fraction();
        f4.SetTop(5);
        Console.WriteLine($"Fraction 4 (SetTop): {f4.GetFractionString()}"); //expected output 5/1
        Console.WriteLine($"Numerator: {f4.GetTop()}");
        Console.WriteLine(f4.GetDecimaValue());

        //using setter for bottom with first constructor
        Fraction f5 = new Fraction();
        f5.SetBottom(4);
        Console.WriteLine($"Fraction 5 (SetBottom): {f5.GetFractionString()}"); //expected output 1/4
        Console.WriteLine($"Denominator: {f5.GetBottom()}");
        Console.WriteLine(f5.GetDecimaValue());
    }
}