using System.Text.Json.Nodes;

public class Race{
    string raceName;
    int[] raceMods;
    string[] raceFeatures;
    int speed;
    string size;
    public Race(Array raceInfo){

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