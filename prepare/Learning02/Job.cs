using System;

public class Job
{
    public string company;
    public string jobTitle;
    public  string startYear;
    public string endYear;
    public void Display(){
        Console.WriteLine($"{jobTitle} ({company}): {startYear}-{endYear}");
    }
}