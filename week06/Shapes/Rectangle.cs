public class Rectangle : Shape
{
    private double _length;
    private double _heigth;

    public Rectangle(string color, double length, double heigth) : base(color)
    {
        _length = length;
        _heigth = heigth;
    }

    public override double GetArea()
    {
        return _length * _heigth;
    }
}