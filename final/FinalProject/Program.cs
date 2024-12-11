using System;

class Program
{
    static void Main(string[] args)
    {
        Dexterity d = new Dexterity("Dexterity", 18);
        Console.WriteLine(d.DispScore(0));
        Console.Write(d.GetSkill(4, 2));
        d.AddSkillProf(1, "x");
        Console.Write(d.GetSkill(1, 2));
    }
}