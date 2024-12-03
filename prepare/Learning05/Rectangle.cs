public class Rectangle : Shape{
    double length;
    double width;
    public Rectangle(){
        SetColor();
        Console.WriteLine("Length: ");
        length = Int64.Parse(Console.ReadLine());
        Console.WriteLine("Width: ");
        width = Int64.Parse(Console.ReadLine());
    }
    public override double GetArea(){
        return length * width;
    }
}