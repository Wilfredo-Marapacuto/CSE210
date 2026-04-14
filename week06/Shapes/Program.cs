using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        Rectangle s2 = new Rectangle("Blue", 4, 5);
        Circle s3 = new Circle("Green", 6);

        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} {s.GetType().Name} has an area of {area:F2}");
        }
    }
}