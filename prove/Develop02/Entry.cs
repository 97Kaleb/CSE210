public class Entry{
    Prompts prompt1 = new Prompts();
    public List<string> writeEntry(List<string> entryList){
        Prompts prompts1 = new Prompts();
        string printPrompt = prompts1.getPrompt();
        Console.WriteLine(printPrompt);
        static string getDate(){
            DateTime today = DateTime.Now;
            string todayString = today.ToString();
            return todayString;
        }
        string date = getDate();
        string input = Console.ReadLine();
        string newEntry = date + "\n" + printPrompt + "\n" + input;
        entryList.Add(newEntry);
        return entryList;
    }
}