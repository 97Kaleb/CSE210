using System;

class Program
{
    static void Main(string[] args){
        while(true){
            Console.WriteLine("1: Breathing Activity\n2: Listing Activity\n3: Reflection Activity\n4: Quit");
            string selection = Console.ReadLine();
            if (selection == "1"){
                Console.WriteLine("Activity Duration: ");
                int duration = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Breath Duration: ");
                int breathDuration = Int32.Parse(Console.ReadLine());
                BreathingActivity act = new BreathingActivity("Breathing Activity", duration, breathDuration);
                act.Run();
            }else if (selection == "2"){
                Console.WriteLine("Activity Duration: ");
                int duration = Int32.Parse(Console.ReadLine());
                ListingActivity act = new ListingActivity("Listing Activity", duration);
                act.Run();
            }else if (selection == "3"){
                Console.WriteLine("Activity Duration: ");
                int duration = Int32.Parse(Console.ReadLine());
                ReflectionActivity act = new ReflectionActivity("Reflection Activity", duration);
                act.Run();
            }else if (selection == "4"){
                break;
            }else{
                Console.WriteLine("Invalid input.");
            }
        }
    }
}