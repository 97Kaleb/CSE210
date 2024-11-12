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