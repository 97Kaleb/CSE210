public class Prompts{
    
    public List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the strongest emotion I felt today?", "What was the best thing I ate today?", "Did anything unexpected happen to me today?", "What was my greatest accomplishment today?"};
    public string getPrompt(){
        Random rand = new Random();
        int randomIndex = rand.Next(0, 4);
        string prompt = prompts[randomIndex];
        return prompt;
    }
}