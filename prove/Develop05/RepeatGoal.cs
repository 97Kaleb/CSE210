public class RepeatGoal : Goal{
    double reps = 0;
    int repValue;
    public RepeatGoal(int repValue, int value, string desc, double count) : base(value, desc, count){
        this.repValue = repValue;
    }
    public override int Complete(){
        reps++;
        if (reps == count){
            complete = "Y";
            return value;
        }else{
            return repValue;
        }
        
    }
    public override void Display(){
        Console.WriteLine($"{desc}   {reps}/{count}");
    }
}