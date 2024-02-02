using System;
using System.ComponentModel.Design;

public class Entry{
    public List<string> writeEntry(List<string> entryList){
        Prompts prompts1 = new Prompts();
        Random rand = new Random();
        int randomIndex = rand.Next(0, 4);
        string printPrompts = prompts1.prompts[randomIndex];
        Console.WriteLine(printPrompts);
        static string getDate(){
            DateTime today = DateTime.Now;
            string todayString = today.ToString();
            return todayString;
        }
        string date = getDate();
        string input = Console.ReadLine();
        string newEntry = date + "\n" + input;
        entryList.Add(newEntry);
        return entryList;
    
    }
}
public class Prompts{
    public List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the strongest emotion I felt today?", "What was the best thing I ate today?", "Did anything unexpected happen to me today?", "What was my greatest accomplishment today?"};
}
class Program
{
    static void Main(string[] args)
    {
        List<string> entries = new List<string>();
        Entry entry1 = new Entry();
        int selection = 0;
        while (selection != 5){
            Console.WriteLine("MENU\n1: Write Entry\n2: Load\n3: Save\n4: Display\n5: Quit");
            selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1){
                // Write Entry
                entries = entry1.writeEntry(entries);
            }else if (selection == 2){
                // Load
                Console.WriteLine("File Path: ");
                string path = Console.ReadLine();
                string loadEntries = File.ReadAllText(path);
                string[] entryArray = loadEntries.Split('|');
                entries = new List<string>();
                foreach (string entry in entryArray){
                    entries.Add(entry);
                }
            }else if (selection == 3){
                // Save
                Console.WriteLine("File Path: ");
                string path = Console.ReadLine();
                Console.WriteLine("Overwrite? (y/n)");
                string overwrite = Console.ReadLine();
                if (overwrite == "y"){
                    File.WriteAllText(path, "");
                }
                foreach (string entry in entries){
                    File.AppendAllText(path, "|" + entry);
                }
            }else if (selection == 4){
                // Display
                string printEntries = string.Join("\n\n", entries);
                Console.WriteLine(printEntries);
            }
        }
    }
}