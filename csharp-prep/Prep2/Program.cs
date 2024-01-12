using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the percentage?");
        string grade;
        int percentage = int.Parse(Console.ReadLine());
        if (percentage >= 90){
            grade="A";
        }else if (percentage >= 80){
            grade="B";
        }else if (percentage >=70){
            grade="C";
        }else if (percentage >=60){
            grade="D";
        }else{
            grade="F";
        }
        Console.WriteLine($"Your grade is {grade}.");
        if (percentage >= 70){
            Console.WriteLine("Congratulations. You passed.");
        }else{
            Console.WriteLine("You failed.");
        }
    }
}