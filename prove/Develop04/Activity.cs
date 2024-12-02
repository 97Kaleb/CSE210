public class Activity{
    protected string name;
    protected int duration;
    public Activity(string name, int duration){
        this.name = name;
        this.duration = duration;
    }
    public void DispBuffer(int duration){
        DateTime start = DateTime.Now;
        DateTime time = start;
        Console.Write("—");
        while (time < start.AddSeconds(duration)){
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b—");
            time = DateTime.Now;
        }
    }
    public DateTime Countdown(){
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration + 3);
        Console.Write("\nBeginning in 3:");
        Thread.Sleep(1000);
        Console.Write("\b\b2:");
        Thread.Sleep(1000);
        Console.Write("\b\b1:");
        Thread.Sleep(1000);
        return end;
    }
        
    public void Done(){
        Console.WriteLine($"You have finished the {name}.");
    }
}