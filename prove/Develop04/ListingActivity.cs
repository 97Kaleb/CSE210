public class ListingActivity : Activity{
    string[] prompts = new string[] {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    public ListingActivity(string name, int duration) : base(name, duration){}
    public void Run(){
        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Random random = new Random();
        int promptsIndex = random.Next(0, prompts.Length - 1);
        Console.Write(prompts[promptsIndex]);
        DateTime end = Countdown();
        int x = 0;
        while(end > DateTime.Now){
            Console.Read();
            x++;
        }
        Console.WriteLine($"\n{x} items listed.");
        Done();
    }
}