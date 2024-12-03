public abstract class Shape{
    string color;
    public string GetColor(){
        return color;
    }
    public void SetColor(){
        Console.WriteLine("Color: ");
        this.color = Console.ReadLine();
    }
    public abstract double GetArea();
}