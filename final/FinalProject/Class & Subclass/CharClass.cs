using System.Text.Json.Nodes;

public abstract class CharClass{
    string className;
    List<string> classProg;
    List<string> classSkills;
    int skillChoices;
    int classLv = 0;
    string classProf;
    List<Boolean> classSaves;
    List<int> subclassFeatureLvs;
    public CharClass(JsonArray classObj){
        
    }
}