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
        // Deal with JSON
    }
    public string GainLv(){
        classLv++;
        // probably needs more work
        return classProg[classLv - 1];
    }
    public int GetLv(){
        return classLv;
    }
    public string DispClasses(){
        return $"{className} {classLv}";
    }
    public List<string> DispFeatures(){
        List<string> obtainedFeatures = new List<string>();
        for (int i = 0; i < classLv; i++){
            obtainedFeatures.Add(classProg[i]);
        }
        return obtainedFeatures;
    }
}