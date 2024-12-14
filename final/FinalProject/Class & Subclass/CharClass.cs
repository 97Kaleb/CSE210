using System.Text.Json.Nodes;

public abstract class CharClass{
    protected string className;
    protected string[] classProg;
    protected string[] classSkills;
    protected int skillChoices;
    protected int classLv = 0;
    protected string[] classProf;
    protected int hitDie;
    protected Boolean[] classSaves = new Boolean[6];
    protected List<int> subclassFeatureLvs;
    public CharClass(Dictionary<string, string> classInfo){}
    public abstract string GainLv();
    public int GetLv(){
        return classLv;
    }
    public virtual string DispClasses(){
        return $"{className} {classLv}";
    }
    public Boolean[] GetClassSaves(){
        return classSaves;
    }
    public abstract List<string> DispFeatures();
}