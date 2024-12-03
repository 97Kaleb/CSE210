public class Circle : Shape{
    double radius;
    public Circle(){
        SetColor();
        Console.WriteLine("Radius: ");
        radius = Int64.Parse(Console.ReadLine());
    }
    public override double GetArea(){
        return radius * radius * Math.PI;
    }
}