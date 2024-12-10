public class InfiniteGoal : Goal{
    public InfiniteGoal(int value, string desc, double count) : base(value, desc, count){}
    public override int Complete(){
        count++;
        return value;
    }
    public override void Display(){
        Console.WriteLine($"{desc}   Achieved {count} times.");
    }
}