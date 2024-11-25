using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Jibby Timbbs", "Tactics");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);
        MathAssignment math = new MathAssignment("Jibby Timbbs", "Differentials", "8.2-8.4", "1-36");
        string mathSummary1 = math.GetSummary();
        string mathSummary2 = math.GetMath();
        string mathSummary = $"{mathSummary1}\n{mathSummary2}";
        Console.WriteLine(mathSummary);
        WritingAssignment writing = new WritingAssignment("Jibby Timbbs", "Literature", "A Book");
        string writingSummary1 = writing.GetSummary();
        string writingSummary2 = writing.GetWriting();
        string writingSummary = $"{writingSummary1}\n{writingSummary2}";
        Console.WriteLine(writingSummary);
    }
}