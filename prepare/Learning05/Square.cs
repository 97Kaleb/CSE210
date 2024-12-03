public class Square : Shape{
    double side;
    public Square(){
        SetColor();
        Console.WriteLine("Side Length: ");
        side = Int64.Parse(Console.ReadLine());
    }
    public override double GetArea(){
        return side * side;
    }
}