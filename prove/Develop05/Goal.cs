public abstract class Goal{
    protected int value;
    protected string desc;
    protected double count;
    public string complete;
    public Goal(int value, string desc, double count){
        this.value = value;
        this.desc = desc;
        this.count = count;
    }
    public abstract int Complete();
    public abstract void Display();
}