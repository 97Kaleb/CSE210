using System.Text.Json.Nodes;

public class Race{
    string raceName;
    List<int> raceMods;
    List<string> raceFeatures;
    int speed;
    string size;
    public Race(JsonArray raceObject){
        // Deal with JSON
    }
    public int GetSpeed(){
        return speed;
    }
    public string GetSize(){
        return size;
    }
    public List<string> GetFeatures(){
        return raceFeatures;
    }
    public List<int> ApplyMods(){
        return raceMods;
    }
}