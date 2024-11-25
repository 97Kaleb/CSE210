public class MathAssignment : Assignment{
    string textbookSection;
    string problems;
    public MathAssignment(string student, string topic, string textbookSection, string problems) : base(student, topic){
        this.textbookSection = textbookSection;
        this.problems = problems;
    }
    public string GetMath(){
        return $"Chapter: {textbookSection}\nProblems: {problems}";
    }
}