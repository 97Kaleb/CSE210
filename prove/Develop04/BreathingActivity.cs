public class BreathingActivity : Activity{
    int breathDuration;

    public BreathingActivity(string name, int duration, int breathDuration) : base(name, duration){
        this.breathDuration = breathDuration;
    }
    public void Run(){
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        DateTime end = Countdown();
        while (end > DateTime.Now){
            Console.WriteLine("Breathe in.");
            DispBuffer(breathDuration);
            Console.WriteLine("Breathe out.");
            DispBuffer(breathDuration);
        }
        Done();
    }
}
