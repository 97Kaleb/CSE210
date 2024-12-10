using System;

class Program
{
    static void Main(string[] args){
        List<Goal> goalListInProgress = new List<Goal>();
        double points = 0;
        while(true){
            Console.WriteLine($"MENU ({points} Points)\n1: Display Current Goals\n2: Add Goal\n3: Register Goal Progress/Completion\n4: Quit");
            string selection = Console.ReadLine();
            if (selection == "1"){
                for(int i = 0; i < goalListInProgress.Count; i++){
                    goalListInProgress[i].Display();
                }
            }else if (selection == "2"){
                Console.WriteLine("Goal Name:");
                string desc = Console.ReadLine();
                Console.WriteLine("Goal Type:\n1: One-Time Goal\n2: Multiple-Time Goal\n3: Endless Goal");
                string subSelection = Console.ReadLine();
                if (subSelection == "1"){
                    Console.WriteLine("Goal Value:");
                    int value = Int32.Parse(Console.ReadLine());
                    goalListInProgress.Add(new SingleGoal(value, desc, 0));
                }else if (subSelection == "2"){
                    Console.WriteLine("Goal Value:");
                    int value = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Goal Count:");
                    int reps = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Goal Individual Value:");
                    int repValue = Int32.Parse(Console.ReadLine());
                    goalListInProgress.Add(new RepeatGoal(repValue, value, desc, reps));
                }else if (subSelection == "3"){
                    Console.WriteLine("Goal Value:");
                    int value = Int32.Parse(Console.ReadLine());
                    goalListInProgress.Add(new InfiniteGoal(value, desc, 0));
                }else{
                Console.WriteLine("Invalid input.");
                }
            }else if (selection == "3"){
                for(int i = 0; i < goalListInProgress.Count; i++){
                    Console.Write($"{i + 1}:   ");
                    goalListInProgress[i].Display();
                }
                Console.WriteLine("Input goal number:");
                int updateSelection = Int32.Parse(Console.ReadLine());
                points = points + goalListInProgress[updateSelection - 1].Complete();
                if (goalListInProgress[updateSelection - 1].complete == "Y"){
                    goalListInProgress.RemoveAt(updateSelection - 1);
                }
            }else if (selection == "4"){
                break;
            }else{
                Console.WriteLine("Invalid input.");
            }
        }
    }
}