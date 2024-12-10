public class SingleGoal : Goal{
    public SingleGoal(int value, string desc, double count) : base(value, desc, count){}
    public override int Complete(){
        complete = "Y";
        return value;
    }
    public override void Display(){
        Console.WriteLine($"{desc}   0/1");
    }
}