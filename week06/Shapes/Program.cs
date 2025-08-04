using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Blue", 12));
        shapes.Add(new Rectangle("Red", 4, 8));
        shapes.Add(new Circle("Green", 7));

        Console.Clear();

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The shape has an area of {s.GetArea()} units.");
            Console.WriteLine();
        }
    
    }   

}