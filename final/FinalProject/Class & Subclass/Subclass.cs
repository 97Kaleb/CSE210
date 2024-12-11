using System.Text.Json.Nodes;

public class Subclass(JsonArray classObj) : CharClass(classObj){
    string subclassName;
    List<int> subClassFeatureLvs;
    List<string> subclassProg;
}