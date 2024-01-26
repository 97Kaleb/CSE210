using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
        job1.company = "Microsoft";
        job1.jobTitle = "Software Engineer";
        job1.startYear = "2019";
        job1.endYear = "2022";
        Job job2 = new();
        job2.company = "Apple";
        job2.jobTitle = "Manager";
        job2.startYear = "2022";
        job2.endYear = "2023";
        Resume resume1 = new();
        resume1.name = "Allison Rose";
        resume1.jobs.Add(job1);
        resume1.jobs.Add(job2);
        resume1.Display();
    }
}