public class Activity{
    protected string name;
    protected int duration;
    public Activity(string name, int duration){
        this.name = name;
        this.duration = duration;
    }
    public void DispBuffer(int duration){
        DateTime start = DateTime.Now;
        Console.WriteLine("—");
        while (start < DateTime.Now.AddSeconds(duration)){
            Thread.Sleep(250);
            Console.WriteLine("\b/");
            Thread.Sleep(250);
            Console.WriteLine("\b|");
            Thread.Sleep(250);
            Console.WriteLine("\b\\");
            Thread.Sleep(250);
            Console.WriteLine("\b—");
        }
    }
    public DateTime Countdown(){
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration + 3);
        Console.WriteLine("Beginning in 3:");
        Thread.Sleep(1000);
        Console.WriteLine("\b\b  \b2:");
        Thread.Sleep(1000);
        Console.WriteLine("\b\b  \b1:");
        Thread.Sleep(1000);
        return end;
    }
        
    public void Done(){
        Console.WriteLine($"You have finished the {name}.");
    }
}