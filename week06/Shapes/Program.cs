using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

        // // Square square = new Square("Red", 5);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        // // Rectangle rectangle = new Rectangle("Blue", 4, 6);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        // // Circle circle = new Circle("Green", 3);

        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());
    }
}