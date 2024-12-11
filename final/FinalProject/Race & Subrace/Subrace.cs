using System.Text.Json.Nodes;

public class Subrace(JsonArray raceObj) : Race(raceObj){
    string subraceName;
    List<int> subraceMods;
    List<string> subraceFeatures;
}