using System.Text.Json.Nodes;

public class Subrace(Array raceInfo) : Race(raceInfo){
    string subraceName;
    int[] subraceMods;
    string[] subraceFeatures;
}