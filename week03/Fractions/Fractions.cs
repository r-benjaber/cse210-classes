

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int number)
    {
        _top = number;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int number)
    {
        _bottom = number;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double DecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}