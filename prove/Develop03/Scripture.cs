public class Scripture{
    string book;
    int chapter;
    int verse;
    string text;
    public Reference reference;
    public Words w;
    public Scripture(string book, int chapter, int verse, string text){
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.text = text;
        reference = new Reference(book, chapter, verse);
        string[] words = text.Split(" ");
        w = new Words(words);
    }
        
    public void Display(Reference reference, Words words){
        Console.WriteLine($"{reference.DispRef()}\n{words.DispText()}");
    }
}