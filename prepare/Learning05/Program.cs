using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square sq = new Square();
        shapes.Add(sq);
        Rectangle re = new Rectangle();
        shapes.Add(re);
        Circle ci = new Circle();
        shapes.Add(ci);
        foreach (Shape shape in shapes){
            Console.WriteLine($"Shape is {shape.GetColor()}. It has an area of {shape.GetArea()}.");
        }
    }
}