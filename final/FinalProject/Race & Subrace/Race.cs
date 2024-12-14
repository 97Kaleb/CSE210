using System.Text.Json.Nodes;

public class Race{
    protected string raceName;
    protected int[] raceMods;
    protected string[] raceFeatures;
    int speed;
    string size;
    public Race(Dictionary<string, string> raceInfo){
        raceName = raceInfo["raceName"];
        size = raceInfo["size"];
        speed = Int32.Parse(raceInfo["speed"]);
    }
    public int GetSpeed(){
        return speed;
    }
    public string GetSize(){
        return size;
    }
    public string[] GetFeatures(){
        return raceFeatures;
    }
    public int[] ApplyMods(){
        return raceMods;
    }
}