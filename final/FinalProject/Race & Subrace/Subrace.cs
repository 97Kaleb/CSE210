using System.Text.Json.Nodes;

public class Subrace : Race{
    string subraceName;
    int[] subraceMods;
    string[] subraceFeatures;
    public Subrace(Dictionary<string, string> raceInfo) : base(raceInfo){
        int srC = 0;
        Console.WriteLine($"Choose a subrace:");
        foreach (string s in raceInfo["subraces"].Split(',')){
            srC++;
            Console.WriteLine(s);
        }
        int selection = Int32.Parse(Console.ReadLine());
        if (selection > srC || selection <= 0){
            Console.WriteLine("Invalid selection. Choose again.");
            selection = Int32.Parse(Console.ReadLine());
        }
        string subraceSelection = raceInfo["subraces"].Split(',')[selection - 1];
        subraceName = subraceSelection.Split(':')[1].Trim(' ');
        raceMods = Array.ConvertAll(raceInfo["Racial Mods"].Split('+'), Int32.Parse);
        subraceMods = Array.ConvertAll(raceInfo[$"{selection}"].Split(',')[0].Split('+'), Int32.Parse);
        subraceFeatures = raceInfo[$"{selection}"].Split(',');
        raceFeatures = raceInfo["Racial Features"].Split(',');
    }
    public int[] GetMods(){
        int[] fullRaceMods = base.ApplyMods().Concat(subraceMods).ToArray();
        return fullRaceMods;
    }
    public string[] GetSubraceFeatures(){
        return subraceFeatures.Skip(1).ToArray();;
    }
    public string GetSubraceName(){
        return subraceName;
    }
}