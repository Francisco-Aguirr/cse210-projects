using System;

public class Fraction
{
    private int _top;        
    private int _bottom;    
                            

//Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()                          
    {
        _top = 1;
        _bottom = 1;
    }

// Constructor that has one parameter for the top and that initializes the denominator to 1.
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

//Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // method to print the fraction in format numerator/denominator
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    //Create a method called GetDecimalValue that returns a double that is the result of dividing
    // the top number by the bottom number, such as 0.75.

    public double GetDecimaValue()
    {
        return (double)_top / (double)_bottom;
    }


    // Create getters and setters for both the top and the bottom values.
    // getter fot _top
    public int GetTop()
    {
        return _top;
    }

    // getter for _bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // setter for top
    public void SetTop(int top)
    {
        _top = top;
    }

    // setter for bottom
    public void SetBottom( int bottom)
    {
        _bottom = bottom;
    }
}