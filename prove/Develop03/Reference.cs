public class Reference{
    string book;
    int chapter;
    int verse;
    public Reference(string book, int chapter, int verse){
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
    }
    public string DispRef(){
        string dRef = $"{book} {chapter}:{verse}";
        return dRef;
    }
}